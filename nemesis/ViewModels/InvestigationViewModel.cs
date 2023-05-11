using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel.DataAnnotations;

namespace nemesis.ViewModels

{
    public class InvestigationViewModel
    {
        public List<ReportViewModel>? Reports { get; set; }


        public int Id { get; set; }

        public int ReportId { get; set; }

        [Required(ErrorMessage = "Description of the investigation is required")]
        [StringLength(50000)]
        [Display(Name = "Investigation Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date of Investigation")]
        public DateTime DateOfAction { get; set; }

        public bool? IncludePhoneNumber { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [StringLength(400)]
        [Display(Name = "Current Status")]
        public string Status { get; set; }



    }
}
