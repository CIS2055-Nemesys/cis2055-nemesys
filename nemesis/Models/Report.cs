namespace nemesis.Models
{
    public class Report
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string[] ImageUrls { get; set; }


        public int CategoryId { get; set; }

        public Category Category { get; set; }



        public int CreatedByUserId { get; set; }

        public User CreatedByUser { get; set; }
    }
}
