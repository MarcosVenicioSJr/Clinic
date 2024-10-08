using Clinic.Models.Responses;

namespace Clinic.Interfaces.Client
{
    public interface IClientService : IServices<Models.Client>
    {
        List<ClientGetAllResponse> GetAll();
    }
}
