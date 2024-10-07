using Clinic.Context;
using Clinic.Interfaces.Client;
using Clinic.Models;

namespace Clinic.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly ClinicContext _context;

        public ClientRepository(ClinicContext context)
        {
            this._context = context;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Client>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Client entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
