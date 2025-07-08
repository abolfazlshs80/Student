namespace Student.Api.Service
{
    public interface IUnitOfWorkService
    {
        Task<bool> SaveAsync( CancellationToken ct);
    }
}