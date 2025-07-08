using Student.Api.Data.Models;
using Student.Api.Models.Students;

namespace Student.Api.Service
{
    public interface IStudentService
    {
        Task<bool> CreateAsync(CreateStudentDto student, CancellationToken ct);
        Task<bool> DeleteAsync(int student,CancellationToken ct);
        Task<StudentDto> GetAsync(int id,CancellationToken ct);
        Task<IEnumerable<StudentDto>> GetAllAsync(int page, CancellationToken ct);
        Task<bool> UpdateAsync(UpdateStudentDto student,CancellationToken ct);
    }
}