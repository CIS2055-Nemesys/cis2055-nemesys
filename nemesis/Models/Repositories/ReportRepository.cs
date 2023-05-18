using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.ViewModels;

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
            _appDbContext.Reports.Add(report);
            _appDbContext.SaveChanges();
        }

        public void DeleteReport(int id)
        {
            _appDbContext.Reports.Remove(GetReportById(id));
            _appDbContext.SaveChanges();
        }

        public void EditReport(Report report)
        {
            _appDbContext.Reports.Update(report);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Category> getAllCategories()
        {
            return _appDbContext.Categories.ToList();
        }
        
        public IEnumerable<Status> getAllStatuses()
        {
            return _appDbContext.Statuses.ToList();
        }

        public IEnumerable<String> getAllLocations()
        {
            return _appDbContext.Reports.Select(r=>r.Location).Distinct().ToList();
        }

        public IEnumerable<String> getAllReporterNames()
        {
            return _appDbContext.Reports.Include(r => r.CreatedByUser).Select(r => r.CreatedByUser.UserName).Distinct().ToList();
        }

        public IEnumerable<Report> getAllReports()
        {
            return _appDbContext.Reports
                .Include(r => r.Category)
                .Include(r => r.CreatedByUser)
                .Include(r => r.Upvotes)
                .OrderByDescending(r => r.DateOfReport)
                .ToList();
        }

        public IEnumerable<Report> getAllReports(FilterViewModel filter)
        {
            IEnumerable<Report> query = _appDbContext.Reports
                .Include(r => r.Category)
                .Include(r => r.CreatedByUser)
                .Include(u => u.Upvotes)
                .Include(u => u.Status)
                .OrderByDescending(r => r.DateOfReport);

            // Apply filters
            if (filter != null)
            {
                if (!string.IsNullOrEmpty(filter.Location))
                {
                    query = query.Where(r => r.Location == filter.Location);
                }

                if (!string.IsNullOrEmpty(filter.Reporter))
                {
                    query = query.Where(r => r.CreatedByUser.UserName == filter.Reporter);
                }

                if (!string.IsNullOrEmpty(filter.Category))
                {
                    query = query.Where(r => r.Category.Name == filter.Category);
                }

                if (!string.IsNullOrEmpty(filter.Status))
                {
                    query = query.Where(r => r.Status.Name == filter.Status);
                }
            }

            return query.ToList();
        }



        public Category? GetCategoryById(int id)
        {
            return _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
        }

        public Report? GetReportById(int id)
        {
            return _appDbContext.Reports
                .Include(r => r.Category)
                .Include(r => r.CreatedByUser)
                .Include(r => r.Upvotes)
                .FirstOrDefault(r => r.Id == id);
        }

     

        public void Upvote(string userId, int reportId)
        {
            bool hasUpvoted = _appDbContext.Upvotes.Any(u => u.UserId == userId && u.ReportID == reportId);

            if (!hasUpvoted)
            {
                // Create a new upvote entry
                Upvote upvote = new Upvote
                {
                    UserId = userId,
                    ReportID = reportId
                };

                _appDbContext.Upvotes.Add(upvote);
            _appDbContext.SaveChanges();
            }
        }

        public void RemoveUpvote(string userId, int reportId)
        {
            var upvote = _appDbContext.Upvotes.FirstOrDefault(u => u.UserId == userId && u.ReportID == reportId);
            if (upvote != null)
            {
                _appDbContext.Upvotes.Remove(upvote);
                _appDbContext.SaveChanges();
            }

        }

        public bool HasUpvoted(string userId, int reportId)
        {
            return _appDbContext.Upvotes.Any(u => u.UserId == userId && u.ReportID == reportId);
        }
    }
}
