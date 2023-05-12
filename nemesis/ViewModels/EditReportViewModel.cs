using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel.DataAnnotations;

namespace nemesis.ViewModels
{
    public class EditReportViewModel
    {

        public List<CategoryViewModel>? Categories { get; set; }
        public List<StatusViewModel>? Statuses { get; set; }


        public int Id { get; set; }

        [Required(ErrorMessage = "A title is required")]
        [StringLength(50)]
        [Display(Name = "Report Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description of the report is required")]
        [StringLength(50000)]
        [Display(Name = "Report Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Location is required")]
        [StringLength(200)]
        [Display(Name = "Incident Location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date spotted")]
        public DateTime DateSpotted { get; set; } = DateTime.Now;

        public DateTime? DateOfReport { get; set; }

        public string? ImageUrl { get; set; }

        [Display(Name = "Image of incident")]
        //[FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]
        public IFormFile ImageToUpload { get; set; } //used only when submitting form


        [Display(Name = "Report Category")]
        //Property used to bind user selection.
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }

        public IdentityUser? CreatedByUser { get; set; }

        public int StatusId { get; set; } = 1;

        public int? InvestigationId { get; set; }

        public int? Upvotes { get; set; }
    }
}
