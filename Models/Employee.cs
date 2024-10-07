namespace Clinic.Models
{
    public class Employee : Person
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
