using Student.Api.Data.Context;

namespace Student.Api.Service
{
    public class UnitOfWorkService(AppDbContext _dbContext) : IUnitOfWorkService
    {
        public async Task<bool> SaveAsync( CancellationToken ct)
        {
            var result = await _dbContext.SaveChangesAsync(ct);
            return result > 0;
        }
    }
}