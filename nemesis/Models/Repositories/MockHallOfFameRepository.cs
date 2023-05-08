using Microsoft.AspNetCore.Identity;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class MockHallOfFameRepository : IHallOfFameRepository
    {
        public List<Report>? _reports;
        public List<IdentityUser>? _users;

        public IEnumerable<UserReportCount> GetTop3Reporters()
        {
            var groupedReports = _reports
                                  .GroupBy(r => r.CreatedByUserId)
                                  .Select(g => new { UserId = g.Key, ReportCount = g.Count() });

            var topReporters = groupedReports
                .OrderByDescending(g => g.ReportCount)
                .Take(3)
                .ToList();

            var top3Users = topReporters
                .Join(_users,
                    g => g.UserId,
                    u => u.Id,
                    (g, u) => new UserReportCount { User = u, ReportCount = g.ReportCount })
                .ToList();

            return top3Users;
        }

    }
}
