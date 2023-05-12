using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel.DataAnnotations;

namespace nemesis.ViewModels

{
    public class EditInvestigationViewModel
    {
        public List<ReportViewModel>? Reports { get; set; }
        public List<StatusViewModel>? Statuses { get; set; }


        public int Id { get; set; }

        public int ReportId { get; set; }

        [Required(ErrorMessage = "Description of the investigation is required")]
        [StringLength(50000)]
        [Display(Name = "Investigation Description")]
        public string Description { get; set; }


        [Display(Name = "Date of Action")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime DateOfAction { get; set; } = DateTime.Now;

        public bool? IncludePhoneNumber { get; set; }

        [Display(Name = "Report Status")]
        [Required(ErrorMessage = "Status is required")]
        public int StatusId { get; set; }





    }
}
