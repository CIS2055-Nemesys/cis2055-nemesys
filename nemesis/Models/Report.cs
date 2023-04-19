﻿namespace nemesis.Models
{
    public class Report
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime DateSpotted { get; set; }

        public DateTime DateOfReport { get; set; }

        public string[]? ImageUrls { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int CreatedByUserId { get; set; }

        public User CreatedByUser { get; set; }

        public bool Status { get; set; }

        public int? InvestigationId { get; set; }

        public int Upvotes { get; set; }
    }
}
