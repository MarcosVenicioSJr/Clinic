namespace Clinic.Interfaces.Client
{
    public interface IClientRepository : IRepository<Models.Client>
    {
        Task<Models.Client> GetByEmail(string email);
    }
}
