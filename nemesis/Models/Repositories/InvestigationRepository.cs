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


        public InvestigationRepository(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }

        public void AddInvestigation(int reportId, Investigation investigation)
        {
            var report = _appDbContext.Reports.SingleOrDefault(r => r.Id == reportId);

          
            _appDbContext.Investigations.Add(investigation);

            _appDbContext.SaveChanges();

            if (report != null)
            {
                report.InvestigationId = investigation.Id;
                report.StatusId = investigation.StatusId;
            }

            
            _appDbContext.SaveChanges();



        }

        public void DeleteInvestigation(int id)
        {
            var report = _appDbContext.Reports.FirstOrDefault(r => r.InvestigationId == id);

            _appDbContext.Investigations.Remove(GetInvestigationById(id));

            if (report != null)
            {
                report.InvestigationId = null;
            }
            _appDbContext.SaveChanges(); 
        }

        public void EditInvestigation(Investigation updatedInvestigation)
        {
            _appDbContext.Investigations.Update(updatedInvestigation);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Investigation> GetAllInvestigations()
        {
            return _appDbContext.Investigations.Include(i => i.InvestigatorId).OrderByDescending(i => i.DateOfAction);
        }

        public IEnumerable<Status> GetAllStatuses()
        {
            return _appDbContext.Statuses.ToList();
        }

        public Investigation GetInvestigationById(int id)
        {
            return _appDbContext.Investigations.Include(r => r.Status).FirstOrDefault(r => r.Id == id);

        }

        //takes investigation id as parameter
        public async Task<string> GetInvestigatorNameAsync(int id)
        {
            var investigation = GetInvestigationById(id);

            var investigator = await _userManager.FindByIdAsync(investigation.InvestigatorId);
            var investigatorUsername = investigator != null ? investigator.UserName : "Unknown";

            return investigatorUsername;
        }

        public int getReportIdByInvestigation(int id)
        {
            var report = _appDbContext.Reports.FirstOrDefault((r) => r.InvestigationId == id);

            return report.Id;
        }

        public Status GetStatusById(int id)
        {
            return _appDbContext.Statuses.FirstOrDefault(s => s.Id == id);
        }

    }
}
