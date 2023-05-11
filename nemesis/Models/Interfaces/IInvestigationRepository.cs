namespace nemesis.Models.Interfaces
{
    public interface IInvestigationRepository
    {
        public IEnumerable<Investigation> GetAllInvestigations();
        public Status GetStatusById(int id);

        public IEnumerable<Status> GetAllStatuses();

        public Investigation GetInvestigationById(int id);

        public void AddInvestigation(int reportId, Investigation investigation);

        public void EditInvestigation(Investigation updatedInvestigation);

        public void DeleteInvestigation(int id);

    }
}
