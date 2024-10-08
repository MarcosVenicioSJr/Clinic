using Clinic.Interfaces.Client;
using Clinic.Mapper;
using Clinic.Models;
using Clinic.Models.Responses;

namespace Clinic.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<ClientGetAllResponse> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll().Result;
            List<ClientGetAllResponse> response = new List<ClientGetAllResponse>();

            Parallel.ForEach(clients, client =>
            {
                response.Add(ClientMapper.MapperGetAll(client));
            });

            return response;
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
