using Microsoft.AspNetCore.Identity;
using nemesis.Models;
using System.ComponentModel;

namespace nemesis.ViewModels
{
    public class InvestigationViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DateOfAction { get; set; }

        public StatusViewModel Status { get; set; }

        [DisplayName("Investigator")]
        public string InvestigatorId { get; set; }

        public string InvestigatorUsername { get; set; }


    }
}
