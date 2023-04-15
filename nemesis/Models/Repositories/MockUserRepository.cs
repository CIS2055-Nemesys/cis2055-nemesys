using nemesis.Models.Interfaces;
using System.Data;
using System.Xml.Linq;
using System;

namespace nemesis.Models.Repositories
{
    public class UserRepository : IUserRepository
    {

        public List<User>? _users;
        public List<Report> _reports;

        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public void DeleteUser(int id)
        {
            foreach(User user in _users)
            {
                if(user.Id == id)
                {
                    _users.Remove(user);
                }
            }
        }

        public void EditUser(int id, string email, string name, int num, bool role)
        {
            foreach (User user in _users)
            {
                if (user.Id == id)
                {
                    user.Name = name;
                    user.Email = email;
                    user.PhoneNum = num; 
                    user.IsInvestigator = role;
                    return;
                }
            }
        }

        //returns all reports made by a specific user
        public IEnumerable<Report> GetAllReportersReports(int id)
        {
            List<Report> _userReports = new List<Report>();

            foreach (Report report in _reports)
            {
                if (report.CreatedByUserId == id)
                {
                    _userReports.Add(report);
                }
            }
            return _userReports;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _users;
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
