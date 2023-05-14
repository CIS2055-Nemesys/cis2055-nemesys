using Microsoft.AspNetCore.Identity;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class MockInvestigationRepository : IInvestigationRepository
    {
        public List<Investigation>? _investigations;
        public List<Report>? _reports;
        public List<Status>? _statuses;
        private readonly UserManager<IdentityUser> _userManager;

        public MockInvestigationRepository(UserManager<IdentityUser> userManager)
        {
            _investigations = new List<Investigation>();
            _reports = new List<Report>();
            _statuses = new List<Status>();
            _userManager = userManager;
        }

        //adds an investigation to the investigations list and updates the associated report with the investigation's id
        public void AddInvestigation(int reportId, Investigation investigation)
        {
            _investigations.Add(investigation);

            var report = _reports.FirstOrDefault(r => r.Id == reportId);
            if (report != null)
            {
                int index = _reports.IndexOf(report);
                _reports[index].InvestigationId = investigation.Id;
            }
        }

        //delete's an investigation and removes the investigation ID from the associated report
        public void DeleteInvestigation(int id)
        {
            var investigation = _investigations.FirstOrDefault(i => i.Id == id);
            if (investigation != null)
            {
                _investigations.Remove(investigation);
            }

            var report = _reports.FirstOrDefault(r => r.InvestigationId == id);
            if (report != null)
            {
                report.InvestigationId = null;
            }
        }

        public void EditInvestigation(Investigation updatedInvestigation)
        {
            var investigation = _investigations.FirstOrDefault(i => i.Id == updatedInvestigation.Id);
            if (investigation != null)
            {
                int index = _investigations.IndexOf(investigation);
                _investigations[index] = updatedInvestigation;
            }
        }

        public IEnumerable<Investigation> GetAllInvestigations()
        {
            return _investigations;
         }


        public IEnumerable<Status> GetAllStatuses()
        {
            return _statuses;
        }

        public Investigation GetInvestigationById(int id)
        {
            return _investigations.FirstOrDefault((i) => i.Id == id); //return null if not found
        }

        public async Task<string> GetInvestigatorNameAsync(int id)
        {
            var investigation = GetInvestigationById(id);
            var investigator = await _userManager.FindByIdAsync(investigation.InvestigatorId);
            var investigatorUsername = investigator != null ? investigator.UserName : "Unknown";

            return investigatorUsername;
        }

        public int getReportIdByInvestigation(int id)
        {
            var report = _reports.FirstOrDefault((r) => r.InvestigationId == id);

            return report.Id;

        }

        public Status GetStatusById(int id)
        {
            return _statuses.FirstOrDefault((c) => c.Id == id); 
        }
    }
}
