using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel;

namespace nemesis.ViewModels
{
    public class ReportViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime DateSpotted { get; set; }

        public DateTime DateOfReport { get; set; }

        public string? ImageUrl { get; set; }

        public CategoryViewModel Category { get; set; }

        public IdentityUser CreatedByUser { get; set; }

        public StatusViewModel Status { get; set; }

        [DisplayName("Investigation")]
        public int? InvestigationId{ get; set; }

        public int Upvotes { get; set; }
    }
}
