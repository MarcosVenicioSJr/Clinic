using Clinic.Models.Enums;

namespace Clinic.Models.Responses
{
    public class ClientGetAllResponse
    {
        public DateTime NextAppointment { get; set; }
        public MedicalPlan MedicalPlan { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
