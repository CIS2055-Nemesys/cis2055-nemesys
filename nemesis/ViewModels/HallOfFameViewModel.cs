using nemesis.Models;

namespace nemesis.ViewModels
{
    public class HallOfFameViewModel
    {
        public int TopReports { get; set; }
        public IEnumerable<Report> Reports { get; set; }
    }
}
