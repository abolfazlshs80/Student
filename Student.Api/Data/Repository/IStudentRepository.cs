using Student.Api.Data.Models;

namespace Student.Api.Data.Repository
{
    public interface IStudentRepository
    {
        Task<bool> CreateAsync(Students student,CancellationToken ct);
        Task<bool> DeleteAsync(Students student);
        Task<Students> GetAsync(int id,CancellationToken ct);
        Task<Students> GetByNationalCodeAsync(string nationalCode,CancellationToken ct);
        Task<IEnumerable<Students>> GetAllAsync(int Take, int Skip ,CancellationToken ct);
        Task<bool> UpdateAsync(Students student);
    
    }
}