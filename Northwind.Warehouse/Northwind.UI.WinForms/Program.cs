using Csla.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Windows.Forms;

namespace Northwind.UI.WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new HostBuilder()
                            .UseCsla((config) =>
                            {
                                config
                                      .PropertyChangedMode(Csla.ApplicationContext.PropertyChangedModes.Windows)
                                      .DataPortal()
                                      .DefaultProxy(typeof(Csla.DataPortalClient.HttpProxy).AssemblyQualifiedName, "https://localhost:44344/api/dataportal/");
                            })
                            .ConfigureServices((hostContext, services) =>
                            {
                                services.AddSingleton<MainForm>();
                                services.AddLogging(configure => configure.AddConsole());
                            });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {

                var services = serviceScope.ServiceProvider;

                try
                {
                    var form1 = services.GetRequiredService<MainForm>();
                    Application.Run(form1);

                    Console.WriteLine("Success");
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception ex)
                {
                    Console.WriteLine("Error Occurred " + ex.Message);
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }
        }
    }
}
