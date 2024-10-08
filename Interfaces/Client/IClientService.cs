using Clinic.Models.Responses;

namespace Clinic.Interfaces.Client
{
    public interface IClientService : IServices<Models.Client>
    {
        List<ClientGetResponse> GetAll();
    }
}
