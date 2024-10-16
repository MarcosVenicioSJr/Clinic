using Clinic.Interfaces.Client;
using Clinic.Mapper;
using Clinic.Models;
using Clinic.Models.Requests;
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

        public void Create(CreateClientRequest entity)
        {
            Client clientExists = _clientRepository.GetByEmail(entity.Email).Result;

            if (clientExists != null)
                return;

            Client client = ClientMapper.MapperRequestToClient(entity);

            _clientRepository.Insert(client);           
        }

        public List<ClientGetResponse> GetAll()
        {
            List<Client> clients = _clientRepository.GetAll().Result;
            List<ClientGetResponse> response = new List<ClientGetResponse>();

            Parallel.ForEach(clients, client =>
            {
                response.Add(ClientMapper.MapperGet(client));
            });

            return response;
        }

        public Client GetById(int id)
        {
            Client client = _clientRepository.GetById(id).Result;
            return client;
        }

        public void MakeAppointment(MakeAppointmentRequest entity)
        {
            Client client = GetById(entity.Id);

            if (client == null)
                return;

            client.NextAppointment = entity.AppointmentDate;

            Update(client);
        }

        public void Update(Client entity)
        {
            _clientRepository.Update(entity);
        }
    }
}
