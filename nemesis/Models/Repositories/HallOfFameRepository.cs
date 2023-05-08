using Microsoft.AspNetCore.Identity;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class HallOfFameRepository : IHallOfFameRepository
    {
        private readonly AppDbContext _appDbContext;

        public HallOfFameRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<UserReportCount> GetTop3Reporters()
        {
            var groupedReports = _appDbContext.Reports
                 .GroupBy(r => r.CreatedByUserId)
                 .Select(g => new { UserId = g.Key, ReportCount = g.Count() });

            var topReporters = groupedReports
                .OrderByDescending(g => g.ReportCount)
                .Take(3)
                .ToList();

            var topUsers = topReporters
                .Join(_appDbContext.Users,
                    g => g.UserId,
                    u => u.Id,
                    (g, u) => new UserReportCount
                    {
                        User = u,
                        ReportCount = g.ReportCount,
                        MostUpvotedReport = GetMostUpvotedReport(g.UserId)
                    })
                .ToList();

            return topUsers;
        }

        public Report GetMostUpvotedReport(string userId)
        {
            return _appDbContext.Reports
                .Where(r => r.CreatedByUserId == userId)
                .OrderByDescending(r => r.Upvotes)
                .FirstOrDefault();
        }
    }
}
