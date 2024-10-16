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

        public async Task<Client> GetByEmail(string email)
        {
            return await _context.Clients.FirstOrDefaultAsync(x => x.Email == email);
        }

        public void Insert(Client entity)
        {
            _context.Clients.AddAsync(entity);

            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Client entity)
        {
            _context.Clients.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
