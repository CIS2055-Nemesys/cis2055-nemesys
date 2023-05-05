namespace nemesis.Models
{
    public class Investigation
    {

        public int Id { get; set; }

        public string? Description { get; set; }

        public DateTime DateOfAction { get; set; }

        public string InvestigatorId { get; set; }


    }
}
