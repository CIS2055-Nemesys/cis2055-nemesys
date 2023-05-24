    using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class InvestigationRepository : IInvestigationRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger _logger;

        public InvestigationRepository(AppDbContext appDbContext, UserManager<IdentityUser> userManager,ILogger<InvestigationRepository> logger)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
            _logger = logger;
        }

        public void AddInvestigation(int reportId, Investigation investigation)
        {
            try
            {
                var report = _appDbContext.Reports.SingleOrDefault(r => r.Id == reportId);

                investigation.PreviousVersionID = report.InvestigationId; //store the id of the prev investigation


                _appDbContext.Investigations.Add(investigation);

                _appDbContext.SaveChanges();

                if (report != null)
                {
                    report.InvestigationId = investigation.Id;
                    report.StatusId = investigation.StatusId;
                }


                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {                
                _logger.LogError(ex, ex.Message);
                throw;
                
            }

        }

        public void DeleteInvestigation(int id)
        {
            try
            {
                var report = _appDbContext.Reports.FirstOrDefault(r => r.InvestigationId == id);

                _appDbContext.Investigations.Remove(GetInvestigationById(id));

                if (report != null)
                {
                    report.InvestigationId = null;
                }
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public void EditInvestigation(Investigation updatedInvestigation)
        {
            try
            {
                _appDbContext.Investigations.Update(updatedInvestigation);
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<Investigation> GetAllInvestigations()
        {
            try
            {
                return _appDbContext.Investigations.Include(i => i.InvestigatorId).OrderByDescending(i => i.DateOfAction);
            } catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<Status> GetAllStatuses()
        {
            try
            {
                return _appDbContext.Statuses.ToList();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public Investigation GetInvestigationById(int id)
        {
            try
            {
                return _appDbContext.Investigations
                    .Include(i => i.Status)
                    .Include(i => i.PreviousVersion)
                    .FirstOrDefault(r => r.Id == id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public async Task<string> GetInvestigatorNameAsync(int id)
        {
            try
            {
                var investigation = GetInvestigationById(id);

                //all investigators must have a username, but this adds an extra layer of protection
                var investigator = await _userManager.FindByIdAsync(investigation.InvestigatorId);
                var investigatorUsername = investigator != null ? investigator.UserName : "Unknown";

                return investigatorUsername;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public int getReportIdByInvestigation(int id)
        {
            try
            {
                var report = _appDbContext.Reports.FirstOrDefault((r) => r.InvestigationId == id);

                return report != null ? report.Id : -1;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public Status GetStatusById(int id)
        {
            try
            {
                return _appDbContext.Statuses.FirstOrDefault(s => s.Id == id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }


    }
}
