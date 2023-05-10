using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel.DataAnnotations;

namespace nemesis.ViewModels

{
    public class InvestigationViewModel
    {
        public List<ReportViewModel>? Reports { get; set; }


        public int InvestigationId { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Description of the investigation is required")]
        [StringLength(50000)]
        [Display(Name = "Investigation Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date of Investigation")]
        public DateTime DateOfAction { get; set; }

        public bool? IncludePhoneNumber { get; set; }

        public string Status { get; set; }
    }
}
