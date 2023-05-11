namespace nemesis.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Investigation> Investigations { get; set; }
    }
}
