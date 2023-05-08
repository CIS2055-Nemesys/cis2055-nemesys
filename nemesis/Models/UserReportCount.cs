using Microsoft.AspNetCore.Identity;

namespace nemesis.Models
{
    public class UserReportCount
    {
        public IdentityUser User { get; set; }
        public int ReportCount { get; set; }
    }
}
