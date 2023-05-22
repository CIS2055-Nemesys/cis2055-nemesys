using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;
using nemesis.ViewModels;
using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Identity;

namespace nemesis.Models.Repositories
{
    public class ReportRepository : IReportRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ILogger<ReportRepository> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public ReportRepository(AppDbContext appDbContext, ILogger<ReportRepository> logger, RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void AddReport(Report report)
        {
            try
            {
                _appDbContext.Reports.Add(report);
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public void DeleteReport(int id)
        {
            try
            {
                _appDbContext.Reports.Remove(GetReportById(id));
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public void EditReport(Report report)
        {
            try
            {
                _appDbContext.Reports.Update(report);
                _appDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<Category> getAllCategories()
        {
            try
            {
                return _appDbContext.Categories.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<Status> getAllStatuses()
        {
            try
            {
                return _appDbContext.Statuses.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<string> getAllLocations()
        {
            try
            {
                return _appDbContext.Reports.Select(r => r.Location).Distinct().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<string> getAllReporterNames()
        {
            try
            {
                return _appDbContext.Reports.Include(r => r.CreatedByUser).Select(r => r.CreatedByUser.UserName).Distinct().ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<Report> getAllReports()
        {
            try
            {
                return _appDbContext.Reports
                    .Include(r => r.Category)
                    .Include(r => r.CreatedByUser)
                    .Include(r => r.Upvotes)
                    .OrderByDescending(r => r.DateOfReport)
                    .ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<Report> getAllReports(FilterViewModel filter)
        {
            try
            {
                IEnumerable<Report> query = _appDbContext.Reports
                    .Include(r => r.Category)
                    .Include(r => r.CreatedByUser)
                    .Include(u => u.Upvotes)
                    .Include(u => u.Status)
                    .OrderByDescending(r => r.DateOfReport);

                // Apply filters
                if (filter != null)
                {
                    if (!string.IsNullOrEmpty(filter.Location))
                    {
                        query = query.Where(r => r.Location == filter.Location);
                    }

                    if (!string.IsNullOrEmpty(filter.Reporter))
                    {
                        query = query.Where(r => r.CreatedByUser.UserName == filter.Reporter);
                    }

                    if (!string.IsNullOrEmpty(filter.Category))
                    {
                        query = query.Where(r => r.Category.Name == filter.Category);
                    }

                    if (!string.IsNullOrEmpty(filter.Status))
                    {
                        query = query.Where(r => r.Status.Name == filter.Status);
                    }
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public Category? GetCategoryById(int id)
        {
            try
            {
                return _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public Report? GetReportById(int id)
        {
            try
            {
                return _appDbContext.Reports
                    .Include(r => r.Category)
                    .Include(r => r.CreatedByUser)
                    .Include(r => r.Upvotes)
                    .Single(r => r.Id == id);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public void Upvote(string userId, int reportId)
        {
            try
            {
                bool hasUpvoted = _appDbContext.Upvotes.Any(u => u.UserId == userId && u.ReportID == reportId);

                if (!hasUpvoted)
                {
                    // Create a new upvote entry
                    Upvote upvote = new Upvote
                    {
                        UserId = userId,
                        ReportID = reportId
                    };

                    _appDbContext.Upvotes.Add(upvote);
                    _appDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public void RemoveUpvote(string userId, int reportId)
        {
            try
            {
                var upvote = _appDbContext.Upvotes.FirstOrDefault(u => u.UserId == userId && u.ReportID == reportId);
                if (upvote != null)
                {
                    _appDbContext.Upvotes.Remove(upvote);
                    _appDbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public bool HasUpvoted(string userId, int reportId)
        {
            try
            {
                return _appDbContext.Upvotes.Any(u => u.UserId == userId && u.ReportID == reportId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                throw;
            }
        }

        public IEnumerable<String> GetAllInvestigatorEmails()
        {
            return _userManager.GetUsersInRoleAsync("Investigator").Result.Select(u=>u.Email);
        }
    }
}
