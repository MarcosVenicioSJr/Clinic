﻿using Clinic.Models;
using Clinic.Models.Responses;

namespace Clinic.Mapper
{
    public static class ClientMapper
    {
        public static ClientGetResponse MapperGetAll(Client client)
        {
            return new ClientGetResponse
            {
                Name = client.Name,
                Email = client.Email,
                BirthDate = client.BirthDate,
                MedicalPlan = client.MedicalPlan,
                NextAppointment = client.NextAppointment,
                Phone = client.Phone
            };
        }
    }
}
