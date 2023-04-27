using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddUser(User user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            _appDbContext.Users.Remove(GetUserById(id));
            _appDbContext.SaveChanges();
        }

        public void EditUser(User updatedUser)
        {
            _appDbContext.Users.Update(updatedUser);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Report> GetAllReportersReports(int id)
        {
            return _appDbContext.Reports.Where(u => u.Id == id).ToList();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _appDbContext.Users.OrderByDescending(u => u.Name);
        }

        public User GetUserById(int id)
        {
            return _appDbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public bool IsInvestigator(int id)
        {
            return _appDbContext.Users.Any(u => u.Id == id && u.IsInvestigator);
        }
    }
}
