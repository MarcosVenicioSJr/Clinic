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

        public List<ClientGetResponse> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll().Result;
            List<ClientGetResponse> response = new List<ClientGetResponse>();

            Parallel.ForEach(clients, client =>
            {
                response.Add(ClientMapper.MapperGetAll(client));
            });

            return response;
        }

        public Client GetById(int id)
        {
            Client client = _clientRepository.GetById(id).Result;
            return client;
        }

        public void Update(Client entity)
        {
            throw new NotImplementedException();
        }
    }
}
