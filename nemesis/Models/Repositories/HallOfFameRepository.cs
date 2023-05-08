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
            return _appDbContext.Reports
                        .GroupBy(r => r.CreatedByUserId)
                        .Select(g => new UserReportCount
                        {
                            User = _appDbContext.Users.FirstOrDefault(u => u.Id == g.Key),
                            ReportCount = g.Count()
                        })
                        .OrderByDescending(urc => urc.ReportCount)
                        .Take(3);
        }
    }
}
