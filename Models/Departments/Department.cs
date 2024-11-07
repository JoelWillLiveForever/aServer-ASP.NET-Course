using aServer_ASP.NET_Course.Models.Employees;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aServer_ASP.NET_Course.Models.Departments
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } = null;
        public List<Employee> Employees { get; set; }
    }
}
