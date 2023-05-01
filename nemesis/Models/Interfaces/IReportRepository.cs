namespace nemesis.Models.Interfaces
{
    public interface IReportRepository
    {
        public void AddReport(Report report);

        public void EditReport(Report report);

        public void DeleteReport(int id);

        public IEnumerable<Report> getAllReports();

        public Report GetReportById(int id);

        public IEnumerable<Category> getAllCategories(int id);

        public Category GetCategoryById(int id);

    }
}
