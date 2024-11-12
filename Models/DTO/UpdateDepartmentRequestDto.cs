namespace aServer_ASP.NET_Course.Models.DTO
{
    public class UpdateDepartmentRequestDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
    }
}
