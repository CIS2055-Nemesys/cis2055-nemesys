using nemesis.Models;

namespace nemesis.ViewModels
{
    public class HallOfFameViewModel
    {
        public int TopUsers { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
