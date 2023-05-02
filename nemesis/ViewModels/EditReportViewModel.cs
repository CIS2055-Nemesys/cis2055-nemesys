using nemesis.Models;

namespace nemesis.ViewModels
{
    public class EditReportViewModel
    {

        public List<CategoryViewModel> Categories { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime DateSpotted { get; set; }

        public DateTime DateOfReport { get; set; }

        public string? ImageUrl { get; set; }

        public IFormFile ImageToUpload { get; set; } //used only when submitting form


        public int CategoryId { get; set; }

        public User CreatedByUser { get; set; }

        public bool Status { get; set; }

        public int? InvestigationId { get; set; }

        public int Upvotes { get; set; }
    }
}
