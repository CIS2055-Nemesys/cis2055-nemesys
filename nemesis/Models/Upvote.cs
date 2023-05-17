using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace nemesis.Models
{
    public class Upvote
    {
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public int ReportID { get; set; }
        public Report Report { get; set; }

        public class UpvoteConfiguration : IEntityTypeConfiguration<Upvote>
        {
            public void Configure(EntityTypeBuilder<Upvote> builder)
            {
                builder.HasKey(u => new { u.UserId, u.ReportID });
            }
        }
    }
}
