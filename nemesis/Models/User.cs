namespace nemesis.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Report> Reports { get; set; }
    }
}
