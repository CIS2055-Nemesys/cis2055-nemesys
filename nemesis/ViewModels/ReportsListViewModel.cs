using nemesis.Models;

namespace nemesis.ViewModels
{
    public class ReportsListViewModel
    {

        public int TotalReports { get; set; }
        public IEnumerable<Report> Reports { get; set; }
    }
}
