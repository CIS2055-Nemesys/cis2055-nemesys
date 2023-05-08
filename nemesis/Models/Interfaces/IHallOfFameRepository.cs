using Microsoft.AspNetCore.Identity;

namespace nemesis.Models.Interfaces
{
    public interface IHallOfFameRepository
    {
        public IEnumerable<UserReportCount> GetTop3Reporters();
    }
}
