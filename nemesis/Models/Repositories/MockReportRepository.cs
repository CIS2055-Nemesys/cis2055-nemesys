using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using nemesis.Migrations;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.ViewModels;

namespace nemesis.Models.Repositories
{
    public class MockReportRepository : IReportRepository
    {

        public List<Report> _reports;
        public List<Category> _categories;
        public List<Status> _statuses;
        public List<Upvote> _upvotes;

        public MockReportRepository() {
            _categories = new List<Category>();
            _reports = new List<Report>();
            _statuses = new List<Status>();
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

        public IEnumerable<Status> getAllStatuses()
        {
            return _statuses;
        }

        public IEnumerable<String> getAllLocations()
        {
            return _reports.Select(r => r.Location).Distinct().ToList();
        }

        public IEnumerable<String> getAllReporterNames()
        {
            return new String[]{"John Doe", "Bill Smith"}.ToList();
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

        public void Upvote(string userId, int reportId)
        {
            bool hasUpvoted = _upvotes.Any(u => u.UserId == userId && u.ReportID == reportId);

            if (!hasUpvoted)
            {
                // Create a new upvote entry
                Upvote upvote = new Upvote
                {
                    UserId = userId,
                    ReportID = reportId
                };

                _upvotes.Add(upvote);
            }
        }
        public void RemoveUpvote(string userId, int reportId)
        {
            var upvote = _upvotes.FirstOrDefault(u => u.UserId == userId && u.ReportID == reportId);
            if (upvote != null)
            {
                _upvotes.Remove(upvote);
            }
        }

        public bool HasUpvoted(string userId, int reportId)
        {
            return _upvotes.Any(u => u.UserId == userId && u.ReportID == reportId);
        }

        public IEnumerable<Report> getAllReports(FilterViewModel f)
        {
            return _reports; //dont bother filtering in mock - assume they all match the filter
        }

        public IEnumerable<string> GetAllInvestigatorEmails()
        {
            return new[] { "nemesis-accounts-um+inv1@wayne.mt", "nemesis-accounts-um+inv2@wayne.mt" }.ToList();
        }
    }
}
