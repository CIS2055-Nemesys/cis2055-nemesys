namespace nemesis.Models.Interfaces
{
    public interface IReportRepository
    {
        public void AddReport(Report report);

        public void EditReport(Report report);

        public void DeleteReport(int id);

        public IEnumerable<Report> getAllReports();

        public Report GetReportById(int id);

        public IEnumerable<Category> getAllCategories();

        public Category GetCategoryById(int id);

        public void Upvote(string userId, int reportId);

    }
}
