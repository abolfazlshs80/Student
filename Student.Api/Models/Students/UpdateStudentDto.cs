namespace Student.Api.Models.Students
{
    public class UpdateStudentDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
