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

        //load the form to create an invesitgation for a report
        [HttpGet]
        [Authorize(Roles = "Investigator")]
        public IActionResult Create(int id /*id of the report*/)
        {
            try
            {
                Report report = _reportRepository.GetReportById(id);

                if (report == null)
                {
                    return NotFound();
                }

                var statusList = _investigationRepository.GetAllStatuses()
                    .Where(c => c.Id != 1)
                    .Select(c => new StatusViewModel()
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                    .ToList();

                var model = new EditInvestigationViewModel
                {
                    ReportId = report.Id, //report that this investigation is attached to
                    Statuses = statusList, //populate status dropdown
                    IncludePhoneNumber = true //Default value, investigator may change this in the form

                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        //Allows users with the investigator role to add an investigation to a report
        //this endpoint is called when the investigation is submitted
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> Create(int id, [Bind("DateOfAction, Description, StatusId, IncludePhoneNumber")] EditInvestigationViewModel newInvestigation)
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
                        PhoneNum = newInvestigation.IncludePhoneNumber ? _userManager.GetUserAsync(User).Result.PhoneNumber : "No phone number available"
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

        //Retreives the investigation entry for a report
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
                    ReportId = _investigationRepository.getReportIdByInvestigation(id),
                    PhoneNum = investigation.PhoneNum
                    
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

        //Retreives the current investigation entry
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

                var statusList = _investigationRepository.GetAllStatuses()
                    .Where(c => c.Id != 1)
                    .Select(c => new StatusViewModel()
                    {
                        Id = c.Id,
                        Name = c.Name
                    })
                    .ToList();

                var model = new EditInvestigationViewModel
                {
                    //load previous values
                    ReportId = report.Id,
                    Statuses = statusList,
                    Description = oldInvestigation.Description,
                    StatusId = oldInvestigation.StatusId,
                    PhoneNum = oldInvestigation.PhoneNum

                };

                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return View("Error");
            }
        }

        //Adds a new investigation to the report, serves as an edit too. This is explained more in the documentation
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Investigator")]
        public async Task<IActionResult> Edit([Bind("DateOfAction, Description, StatusId, IncludePhoneNumber")] EditInvestigationViewModel newInvestigation, int reportId)
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
                        PhoneNum = newInvestigation.IncludePhoneNumber ? _userManager.GetUserAsync(User).Result.PhoneNumber : "No phone number available"

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

