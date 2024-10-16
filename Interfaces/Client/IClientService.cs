using Clinic.Models.Requests;
using Clinic.Models.Responses;

namespace Clinic.Interfaces.Client
{
    public interface IClientService : IServices<Models.Client>
    {
        List<ClientGetResponse> GetAll();

        void Create(CreateClientRequest entity);

        void MakeAppointment(MakeAppointmentRequest entity);
    }
}
