using Microsoft.AspNetCore.Identity;
using nemesis.Models.Contexts;

namespace nemesis.Models.Interfaces
{
    public interface IHallOfFameRepository
    {
        public IEnumerable<UserReportCount> GetTop3Reporters();

        public Report GetMostUpvotedReport(string userId);
       
    }
}
