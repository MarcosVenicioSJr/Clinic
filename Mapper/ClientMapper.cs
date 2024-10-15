using Clinic.Models;
using Clinic.Models.Requests;
using Clinic.Models.Responses;

namespace Clinic.Mapper
{
    public static class ClientMapper
    {
        public static ClientGetResponse MapperGet(Client client)
        {
            return new ClientGetResponse
            {
                Name = client.Name,
                Email = client.Email,
                BirthDate = client.BirthDate,
                MedicalPlan = client.MedicalPlan,
                NextAppointment = client.NextAppointment.Value,
                Phone = client.Phone
            };
        }

        public static Client MapperRequestToClient(CreateClientRequest request)
        {
            return new Client
            {
                Name = request.Name,
                Email = request.Email,
                BirthDate = request.BirthDate,
                MedicalPlan = request.MedicalPlan,
                Phone = request.Phone,
                NextAppointment = null
            };
        }
    }
}
