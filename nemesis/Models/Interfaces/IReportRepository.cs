using nemesis.ViewModels;

namespace nemesis.Models.Interfaces
{
    public interface IReportRepository
    {
        public void AddReport(Report report);

        public void EditReport(Report report);

        public void DeleteReport(int id);

        public IEnumerable<Report> getAllReports();
        public IEnumerable<Report> getAllReports(FilterViewModel f);

        public Report GetReportById(int id);

        public IEnumerable<Category> getAllCategories();

        IEnumerable<Status> getAllStatuses();

        IEnumerable<string> getAllLocations();

        IEnumerable<string> getAllReporterNames();

        public Category GetCategoryById(int id);

        public void Upvote(string userId, int reportId);

        public void RemoveUpvote(string userId, int reportId);

        public bool HasUpvoted(string userId, int reportId);
        
    }
}
