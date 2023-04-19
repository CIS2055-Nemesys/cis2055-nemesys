using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class ReportRepository : IReportRepository
    {


        private readonly AppDbContext _appDbContext;

        public ReportRepository(AppDbContext appDbContext) {
            _appDbContext = appDbContext;
        }

        public void AddReport(Report report)
        {
            _appDbContext.reports.Add(report);
        }

        public void DeleteReport(int id)
        {
            _appDbContext.reports.Remove(GetReportById(id));
        }

        public void EditReport(Report report)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> getAllCategories(int id)
        {
            return _appDbContext.categories.ToList();
        }

        public IEnumerable<Report> getAllReports()
        {
            return _appDbContext.reports.Include(r => r.Category).Include(r=> r.CreatedByUser).OrderByDescending(r=>r.DateOfReport);
        }

        public Category? GetCategoryById(int id)
        {
            return _appDbContext.categories.FirstOrDefault(c => c.Id == id);
        }

        public Report? GetReportById(int id)
        {
            return _appDbContext.reports.Include(r => r.Category).Include(r => r.CreatedByUser).FirstOrDefault(r => r.Id == id);
        }
    }
}
