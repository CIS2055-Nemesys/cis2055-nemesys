namespace nemesis.Models.Interfaces
{
    public interface IReportRepository
    {
        public IEnumerable<Report> getAllReports();

        public Report GetReportById(int id);

        public IEnumerable<Category> getAllCategories(int id);
        public Category GetCategoryById(int id);

    }
}
