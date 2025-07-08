using Microsoft.EntityFrameworkCore;
using Student.Api.Data.Context;

namespace Student.Api.Tools.Extention;

public static class ContextConfigureExtentionMethod
{

    public static IServiceCollection ConfigureContext(this IServiceCollection service, ConfigurationManager configuration)
    {


        service.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
        return service;
    }
}
