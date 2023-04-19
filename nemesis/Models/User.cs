namespace nemesis.Models
{
    public class User
    {
        public int? Id { get; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public int? PhoneNum { get; set; }

        public int? Ranking { get; set; }

        public bool IsInvestigator { get; set; }

        List<Report>? Reports { get; set; }
    }
}
