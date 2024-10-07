using Clinic.Models.Enums;

namespace Clinic.Models
{
    public class Client : Person
    {
        public int Id { get; set; }
        public DateTime NextAppointment { get; set; }
        public MedicalPlan MedicalPlan { get; set; }
    }
}