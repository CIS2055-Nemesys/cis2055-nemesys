namespace nemesis.Models.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();

        public User GetUserById(int id);

        public IEnumerable<Report> GetAllReportersReports(int id);

        public void AddUser(User user);

        public void EditUser(int id, string email, string name, int num, bool role);

        public void DeleteUser(int id);

        public bool IsInvestigator(int id);

    }
}
