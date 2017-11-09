using System;
using System.IO;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    /// <summary>
    /// This class takes care of the configuration
    /// </summary>
    public class Config : IDisposable
    {
        #region Variables

        public IConfigurationRoot settings { get; set; }
        public IFortnoxRepository fortnox_repository { get; set; }
        public HttpClient client { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Config()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            builder.AddJsonFile($"appsettings.Development.json", optional: true);
            this.settings = builder.Build();

            // Create a service collection
            IServiceCollection services = new ServiceCollection();

            // Add services for logging and for options
            services.AddLogging();
            services.AddOptions();

            // Create api options
            services.Configure<FortnoxOptions>(this.settings.GetSection("FortnoxOptions"));

            // Add repositories
            services.AddScoped<IFortnoxRepository, FortnoxRepository>();

            // Build a service provider
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // Configure logging
            ILoggerFactory loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddConsole(this.settings.GetSection("Logging"));
            loggerFactory.AddDebug();
            loggerFactory.AddFile("Logs/test-{Date}.txt");

            // Get a references
            this.fortnox_repository = serviceProvider.GetService<IFortnoxRepository>();
            this.client = this.fortnox_repository.GetClient();

        } // End of the constructor

        #endregion

        #region IDisposable Support

        // To detect redundant calls
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose of the client
                    if(this.client != null)
                    {
                        this.client.Dispose();
                    }
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }

        } // End of the Dispose method

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~Config() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);

        } // End of the Dispose method

        #endregion

    } // End of the class

} // End of the namespace