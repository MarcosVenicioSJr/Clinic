using Clinic.Context;
using Clinic.Interfaces.Client;
using Clinic.Models;
using Microsoft.EntityFrameworkCore;

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

        public async Task<List<Client>> GetAll()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client> GetById(int id)
        {
            return await _context.Clients.FirstOrDefaultAsync(x => x.Id == id);
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
