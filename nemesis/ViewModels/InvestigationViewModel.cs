using Microsoft.AspNetCore.Identity;
using nemesis.Models;

namespace nemesis.ViewModels
{
    public class InvestigationViewModel
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime DateOfAction { get; set; }

        public string InvestigatorId { get; set; }

        public StatusViewModel Status { get; set; }


    }
}
