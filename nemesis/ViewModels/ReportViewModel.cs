﻿using Microsoft.AspNetCore.Identity;
using nemesis.Models;

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

        public bool Status { get; set; }

        public int? InvestigationId { get; set; }

        public int Upvotes { get; set; }
    }
}