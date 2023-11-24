namespace MVC_ASP.ET_Core.Models
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public int JobTitleId { get; set; }
    }
}
