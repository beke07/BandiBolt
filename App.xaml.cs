using Bolt.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows;

namespace Bolt
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();
            ServiceProvider.GetRequiredService<MainWindow>();
        }
    }
}
