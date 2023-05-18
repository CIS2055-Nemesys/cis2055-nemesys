using nemesis.Models;

namespace nemesis.ViewModels
{
    public class ReportsListViewModel
    {

        public int TotalReports { get; set; }
        public IEnumerable<Report> Reports { get; set; }

        // Pagination Variables
        public int ReportsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalReports / ReportsPerPage);
    }
}
