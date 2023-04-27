﻿using Microsoft.EntityFrameworkCore;
using nemesis.Models.Contexts;
using nemesis.Models.Interfaces;

namespace nemesis.Models.Repositories
{
    public class InvestigationRepository : IInvestigationRepository
    {
        private readonly AppDbContext _appDbContext;
        

        public InvestigationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddInvestigation(int reportId, Investigation investigation)
        {
            var report = _appDbContext.Reports.SingleOrDefault(r => r.Id == reportId);

            if (report != null)
            {
                report.InvestigationId = investigation.Id;
            }

            _appDbContext.Investigations.Add(investigation);
            _appDbContext.SaveChanges(); 
        }

        public void DeleteInvestigation(int id)
        {
            var report = _appDbContext.Reports.FirstOrDefault(r => r.InvestigationId == id);

            _appDbContext.Investigations.Remove(GetInvestigationById(id));

            if (report != null)
            {
                report.InvestigationId = null;
            }
            _appDbContext.SaveChanges(); 
        }

        public void EditInvestigation(Investigation updatedInvestigation)
        {
            _appDbContext.Investigations.Update(updatedInvestigation);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<Investigation> GetAllInvestigations()
        {
            return _appDbContext.Investigations.Include(i => i.InvestigatorId).OrderByDescending(i => i.DateOfAction);
        }

        public Investigation GetInvestigationById(int id)
        {
            return _appDbContext.Investigations.FirstOrDefault(i => i.Id == id);
        }
    }
}