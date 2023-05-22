using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using nemesis.Models;
using nemesis.Models.Interfaces;
using nemesis.Models.Repositories;
using nemesis.ViewModels;
using System.Data;

namespace nemesis.Controllers
{
    public class InvestigationsController : Controller
    {
        private readonly IInvestigationRepository _investigationRepository;
        private readonly IReportRepository _reportRepository;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger<ReportsController> _logger;


        public InvestigationsController(
            IReportRepository reportRepository,
            UserManager<IdentityUser> userManager,
            IInvestigationRepository investigationRepository,
            IEmailSender emailSender,
            ILogger<ReportsController> logger

            )
        {
            _reportRepository = reportRepository;
            _investigationRepository = investigationRepository;
            _userManager = userManager;
            _emailSender = emailSender;
            _logger = logger;

        }

        [HttpGet]
        [Authorize(Roles = "Investigator")]
        public IActionResult Create(int id)
        {
            try
            {
                Report report = _reportRepository.GetReportById(id);

                if (report == null)
                {
                    return NotFound();
                }

                var statusList = _investigationRepository.GetAllStatuses().Select(c => new StatusViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                var model = new EditInvestigationViewModel
                {
                    ReportId = report.Id,
                    Statuses = statusList
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> Create(int id, [Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Investigation investigation = new Investigation()
                    {
                        Description = newInvestigation.Description,
                        DateOfAction = newInvestigation.DateOfAction,
                        InvestigatorId = _userManager.GetUserId(User),
                        StatusId = newInvestigation.StatusId
                    };

                    _investigationRepository.AddInvestigation(id, investigation);

                    Report r = _reportRepository.GetReportById(id);

                    await _emailSender.SendEmailAsync(r.CreatedByUser.Email, "New Investigation on your report", "An investigator has added an investigation to your report \"" + r.Title + "\"");

                    return RedirectToAction("Index", "Reports");
                }
                else
                {
                    return View(newInvestigation);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> InvestigationAsync(int id)
        {
            try
            {
                var investigation = _investigationRepository.GetInvestigationById(id);

                if (investigation == null)
                    return NotFound();

                var investigatorUsername = await _investigationRepository.GetInvestigatorNameAsync(id);

                var model = new InvestigationViewModel()
                {
                    DateOfAction = DateTime.Now,
                    Description = investigation.Description,
                    InvestigatorId = investigation.InvestigatorId,
                    InvestigatorUsername = investigatorUsername,
                    PreviousVersion = investigation.PreviousVersion,
                    ReportId = _investigationRepository.getReportIdByInvestigation(id)
                };

                var status = _investigationRepository.GetStatusById(investigation.StatusId);
                if (status != null)
                {
                    model.Status = new StatusViewModel()
                    {
                        Id = status.Id,
                        Name = status.Name
                    };
                }

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpGet]
        [Authorize]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                Report report = _reportRepository.GetReportById(id);
                Investigation oldInvestigation = _investigationRepository.GetInvestigationById((int)report.InvestigationId);

                if (report == null)
                {
                    return NotFound();
                }

                string loggedInUserId = _userManager.GetUserAsync(User).Result.Id;

                if (oldInvestigation.InvestigatorId != loggedInUserId)
                {
                    return Unauthorized(); // User is not authorized to edit the report
                }

                var statusList = _investigationRepository.GetAllStatuses().Select(c => new StatusViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToList();

                var model = new EditInvestigationViewModel
                {
                    ReportId = report.Id,
                    Statuses = statusList,
                    Description = oldInvestigation.Description,
                    StatusId = oldInvestigation.StatusId
                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> Edit([Bind("DateOfAction, Description, StatusId")] EditInvestigationViewModel newInvestigation, int reportId)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Investigation investigation = new Investigation()
                    {
                        Description = newInvestigation.Description,
                        DateOfAction = newInvestigation.DateOfAction,
                        InvestigatorId = _userManager.GetUserId(User),
                        StatusId = newInvestigation.StatusId,
                    };

                    _investigationRepository.AddInvestigation(reportId, investigation);

                    Report report = _reportRepository.GetReportById(reportId);
                    await _emailSender.SendEmailAsync(report.CreatedByUser.Email, "Edited Investigation on your report", "An investigator has edited an investigation to your report \"" + report.Title + "\"");

                    return RedirectToAction("Index", "Reports");
                }
                else
                {
                    return View(newInvestigation);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }
    }
}

