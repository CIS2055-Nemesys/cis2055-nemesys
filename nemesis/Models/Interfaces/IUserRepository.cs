namespace nemesis.Models.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAllUsers();

        public User GetUserById(int id);

        public IEnumerable<Report> GetAllReportersReports(int id);

        public void AddUser(User user);

        public void EditUser(User updatedUser);

        public void DeleteUser(int id);

        public bool IsInvestigator(int id);

        public IEnumerable<User> GetTop3Reporters();


    }
}
