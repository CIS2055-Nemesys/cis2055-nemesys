using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class MockInvestigationRepository : IInvestigationRepository
    {
        public List<Investigation>? _investigations;
        public List<Report>? _reports;

        public MockInvestigationRepository() { 
            _investigations = new List<Investigation>();
            _reports = new List<Report>();

        }
        
        //adds an investigation to the investigations list and updates the associated report with the investigation's id
        public void AddInvestigation(int reportId, Investigation investigation)
        {
            _investigations.Add(investigation);

            var report = _reports.FirstOrDefault(u => u.Id == reportId);
            if (report != null)
            {
                int index = _reports.IndexOf(report);
                _reports[index].InvestigationId = investigation.Id;
            }
        }

        //delete's an investigation and removes the investigation ID from the associated report
        public void DeleteInvestigation(int id)
        {
            var investigation = _investigations.FirstOrDefault(u => u.Id == id);
            if (investigation != null)
            {
                _investigations.Remove(investigation);
            }

            var report = _reports.FirstOrDefault(u => u.InvestigationId == id);
            if (report != null)
            {
                report.InvestigationId = null;
            }
        }

        public void EditInvestigation(Investigation updatedInvestigation)
        {
            var investigation = _investigations.FirstOrDefault(u => u.Id == updatedInvestigation.Id);
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

        public Investigation GetInvestigationById(int id)
        {
            return _investigations.FirstOrDefault((r) => r.Id == id); //return null if not found
        }
    }
}
