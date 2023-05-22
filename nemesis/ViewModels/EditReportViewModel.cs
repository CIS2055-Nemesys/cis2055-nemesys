using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel.DataAnnotations;

namespace nemesis.ViewModels
{
    public class EditReportViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Description of the report is required")]
        [StringLength(50000)]
        [Display(Name = "Report Description")]
        public string Description { get; set; }

        public DateTime? DateOfReport { get; set; }

        public string? ImageUrl { get; set; }

        [Display(Name = "Image of incident")]
        //[FileExtensions(Extensions = "jpg,png,gif,jpeg,bmp,svg")]
        public IFormFile? ImageToUpload { get; set; } //used only when submitting form

        public bool IncludePhoneNumber { get; set; }

        public string? PhoneNum { get; set; }

    }
}
