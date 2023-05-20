using Microsoft.AspNetCore.Identity;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace nemesis.Models.Repositories
{
    public class HallOfFameRepository : IHallOfFameRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<HallOfFameRepository> _logger;

        public HallOfFameRepository(AppDbContext appDbContext, ILogger<HallOfFameRepository> logger)
        {
            _appDbContext = appDbContext;
            _logger = logger;
        }

        public IEnumerable<UserReportCount> GetTop3Reporters()
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public Report GetMostUpvotedReport(string userId)
        {
            try
            {
                return _appDbContext.Reports
                    .Where(r => r.CreatedByUserId == userId)
                    .OrderByDescending(r => r.Upvotes.Count)
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }
    }
}
