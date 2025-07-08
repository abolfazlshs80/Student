using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Student.WinForm;
using Student.WinForm.Service;

namespace Student.WinForm
{
    internal static class Program
    {
        public static IHost AppHost { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
         

            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    ConfigureServices(services);

                    services.AddTransient<MainPage>(); // اضافه کردن فرم اصلی به DI
                })
                .Build();

            using (var scope = AppHost.Services.CreateScope())
            {
                var mainForm = scope.ServiceProvider.GetRequiredService<MainPage>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IStudentApiClient, StudentApiService>();


        }
    }
}