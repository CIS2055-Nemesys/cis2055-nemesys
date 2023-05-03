using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class MockReportRepository : IReportRepository
    {

        public List<Report> _reports;
        public List<Category> _categories;

        public MockReportRepository() {
            _categories = new List<Category>();
            _reports = new List<Report>();
        }

        public void AddReport(Report report)
        {
            _reports.Add(report);
         }

        public void DeleteReport(int id)
        {
            var report = _reports.FirstOrDefault(r => r.Id == id);
            if (report != null)
            {
                _reports.Remove(report);
            }
        }

        public void EditReport(Report updatedreport)
        {
            var report = _reports.FirstOrDefault(r => r.Id == updatedreport.Id);
            if (report != null)
            {
                int index = _reports.IndexOf(report);
                _reports[index] = updatedreport;
            }
        }

        public IEnumerable<Category> getAllCategories()
        {
            return _categories;
        }

        public IEnumerable<Report> getAllReports()
        {
            return _reports;
        }

        public Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault((c) => c.Id == id); //return null if not found
        }

        public Report GetReportById(int id)
        {
            return _reports.FirstOrDefault((r) => r.Id == id); //return null if not found
        }

        public IEnumerable<Report> GetTop3Reports()
        {
            return _reports.OrderByDescending(r => r.Upvotes).Take(3);
        }
    }
}
