using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    /// <summary>
    /// This class takes care of the configuration
    /// </summary>
    public class Config
    {
        #region Variables

        public IConfigurationRoot settings { get; set; }
        public IFortnoxClient fortnox_client { get; set; }
        public ILogger logger { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Config()
        {
            // Set the default directory path for storage
            string directory = "D:\\home\\FortnoxClient";

            // Validate configuration
            ValidateConfiguration validate = new ValidateConfiguration(directory);
            if (validate.Run() == false)
            {
                return;
            }

            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(directory);
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
            services.AddHttpClient<IFortnoxClient, FortnoxClient>();

            // Build a service provider
            IServiceProvider serviceProvider = services.BuildServiceProvider();

            // Configure logging
            ILoggerFactory loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddConsole(this.settings.GetSection("Logging"));
            loggerFactory.AddDebug();
            loggerFactory.AddFile(directory + "\\Logs\\test-{Date}.txt");

            // Get references
            this.logger = loggerFactory.CreateLogger<IFortnoxClient>();
            this.fortnox_client = serviceProvider.GetService<IFortnoxClient>();

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace