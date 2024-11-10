using aServer_ASP.NET_Course.Models.Employees;

namespace aServer_ASP.NET_Course.Models.DTO
{
    public class EmployeeRequestDto
    {
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }

        //public Employee Employee { get; set; }
    }
}
