using Microsoft.EntityFrameworkCore;
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
            _appDbContext.Investigations.Add(investigation);
        }

        public void DeleteInvestigation(int id)
        {
            _appDbContext.Investigations.Remove(GetInvestigationById(id));
        }

        public void EditInvestigation(Investigation updatedInvestigation)
        {
            _appDbContext.Investigations.Update(updatedInvestigation);
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
