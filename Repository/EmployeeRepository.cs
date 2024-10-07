using Clinic.Context;
using Clinic.Interfaces.Employee;
using Clinic.Models;

namespace Clinic.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly ClinicContext _context;

        public EmployeeRepository(ClinicContext context)
        {
            this._context = context;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
