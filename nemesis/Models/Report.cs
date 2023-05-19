using Microsoft.AspNetCore.Identity;

namespace nemesis.Models
{
    public class Report
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime DateSpotted { get; set; }

        public DateTime DateOfReport { get; set; }

        public string? ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string CreatedByUserId { get; set; }

        public IdentityUser CreatedByUser { get; set; }

        public int StatusId { get; set; } = 1;

        public Status Status { get; set; }

        public int? InvestigationId { get; set; }

        public ICollection<Upvote>? Upvotes { get; set; }
    }
}
