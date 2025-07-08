using Microsoft.EntityFrameworkCore;
using Student.Api.Data.Context;
using Student.Api.Data.Models;
using System.Collections.Generic;

namespace Student.Api.Data.Repository
{
    public class StudentRepository : IStudentRepository
    {
        DbSet<Students> _dbSetStudent;

        public StudentRepository(AppDbContext _appDbContext)
        {
            _dbSetStudent = _appDbContext.Students;
        }

        public async Task<IEnumerable<Students>> GetAllAsync(int take, int skip, CancellationToken ct) =>
            await _dbSetStudent.Skip(skip).Take(take).AsNoTracking().ToListAsync(ct);
        public async Task<Students> GetAsync(int id, CancellationToken ct) =>
            await _dbSetStudent.FirstOrDefaultAsync(_ => _.Id==id, ct);
        public async Task<bool> CreateAsync(Students student, CancellationToken ct)
        {
            await _dbSetStudent.AddAsync(student, ct);
            return true;
        }
        public async Task<bool> UpdateAsync(Students student)
        {
            _dbSetStudent.Update(student);
            return true;
        }
        public async Task<bool> DeleteAsync(Students student)
        {
            _dbSetStudent.Remove(student);
            return true;
        }

        public async Task<Students> GetByNationalCodeAsync(string nationalCode, CancellationToken ct)
        {
         return await _dbSetStudent.FirstOrDefaultAsync(_ => _.NationalCode == nationalCode, ct);
        }
    }
}
