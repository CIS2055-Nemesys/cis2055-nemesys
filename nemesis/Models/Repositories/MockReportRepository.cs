using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class ReportRepository : IReportRepository
    {

        public List<Report> _reports;

        public ReportRepository() { 
            _reports = new List<Report>();
        }

        public IEnumerable<Category> getAllCategories(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Report> getAllReports()
        {
            IEnumerable<Report> result = new List<Report>();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public Report GetReportById(int id)
        {
            return _reports.FirstOrDefault((r) => r.Id == id); //return null if not found
        }
    }
}
