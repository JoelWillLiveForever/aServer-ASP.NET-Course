using aServer_ASP.NET_Course.Models.Users;

namespace aServer_ASP.NET_Course.Models.Employees
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MidleName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }

        //public User User { get; set; }
        public List<Education> Educations {  get; set; }
        public List<WorkExperience> WorkExperience { get; set; }
        public List<UserFile> UserFiles { get; set; }
    }
}
