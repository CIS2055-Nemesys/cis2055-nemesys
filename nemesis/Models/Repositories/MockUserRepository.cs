using nemesis.Models.Interfaces;
using System.Data;
using System.Xml.Linq;
using System;

namespace nemesis.Models.Repositories
{
    public class MockUserRepository : IUserRepository
    {

        public List<User>? _users;
        public List<Report>? _reports;

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public void EditUser(User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user != null)
            {
                int index = _users.IndexOf(user);
                _users[index] = updatedUser;
            }
        }

        //returns all reports made by a specific user
        public IEnumerable<Report> GetAllReportersReports(int id)
        {
            return _reports.Where(r => r.CreatedByUserId == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
        }

        public IEnumerable<User> GetTop3Reporters()
        {
            var groupedReports = _reports
                   .GroupBy(r => r.CreatedByUserId)
                   .Select(g => new { UserId = g.Key, ReportCount = g.Count() });

            // Sort the result by the count in descending order and take the top 3 items
            var topReporters = groupedReports
                .OrderByDescending(g => g.ReportCount)
                .Take(3)
                .ToList();

            var top3Users = topReporters
                .Join(_users,
                g => g.UserId,
                u => u.Id,
                (g, u) => u)
                .ToList();

                // Return the top 3 users
                return top3Users;
        }

        public User GetUserById(int id)
        {
            return _users.FirstOrDefault((r) => r.Id == id); //return null if not found
        }

        //checks if a user has the investigator role
        public bool IsInvestigator(int id)
        {
           if(_users.Find(u => u.Id == id)?.IsInvestigator == true)
            {
                return true;
            }
            return false;
        }

       
    }
}
