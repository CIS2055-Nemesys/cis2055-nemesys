using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel;

namespace nemesis.ViewModels
{
    public class InvestigationViewModel
    {
        public int Id { get; set; }

        public int ReportId { get; set; }

        public string Description { get; set; }

        public DateTime DateOfAction { get; set; } = DateTime.Now;

        public StatusViewModel Status { get; set; }

        [DisplayName("Investigator")]
        public string InvestigatorId { get; set; }

        public string InvestigatorUsername { get; set; }

        public Investigation PreviousVersion { get; set; }

    }
}
