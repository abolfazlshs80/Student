namespace Student.Api.Models.Students
{
    public class CreateStudentDto
    {
        public string FullName { get; set; }
        public string NationalCode { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
