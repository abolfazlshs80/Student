using Student.Api.Data.Repository;
using Student.Api.Service;

namespace Student.Api.Tools.Extention;

public static class AddServiceExtentionMethod
{
    public static IServiceCollection AddCustomService(this IServiceCollection collection)
    {
        collection.AddScoped<IUnitOfWorkService, UnitOfWorkService>();
        collection.AddScoped<IStudentService, StudentService>();
        collection.AddScoped<IStudentRepository, StudentRepository>();

        return collection;
    }
}
