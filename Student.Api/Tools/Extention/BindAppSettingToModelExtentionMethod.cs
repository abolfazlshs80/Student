using Student.Api.Models.AppSetting;

namespace Student.Api.Tools.Extention;

public static class BindAppSettingToModelExtentionMethod
{
    public static WebApplicationBuilder BindModel(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<PaginationDto>(
            builder.Configuration.GetSection("Pagination"));
        return builder;
    }
}
