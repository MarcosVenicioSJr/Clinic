using Clinic.Models.Enums;

namespace Clinic.Models.Requests
{
    public class CreateClientRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public MedicalPlan MedicalPlan { get; set; }
    }
}
