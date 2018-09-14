using System;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Annytab.Fortnox.Client.V3;
using System.Net.Http;
using Microsoft.Extensions.Options;

namespace TestProgram
{
    /// <summary>
    /// Check configuration values for errors
    /// </summary>
    public class ValidateConfiguration
    {
        #region Variables

        private string directory { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ValidateConfiguration(string directory)
        {
            // Set values for instance variables
            this.directory = directory;

        } // End of the constructor

        #endregion

        #region Run methods

        /// <summary>
        /// Do the work
        /// </summary>
        public bool Run()
        {
            // Create variables
            bool success = true;
            string path = this.directory + "\\appsettings.json";

            // Make sure that the file exists
            if (System.IO.File.Exists(path) == false)
            {
                LogError($"File not found: {path}, create a new appsettings.json file from appsettings.template.json!!");
                return false;
            }

            try
            {
                // Get the data
                string data = System.IO.File.ReadAllText(path, Encoding.UTF8);

                // Convert data to app settings
                AppSettings app_settings = JsonConvert.DeserializeObject<AppSettings>(data);
                
                // Check for errors
                if (app_settings.FortnoxOptions.ClientId == "" || app_settings.FortnoxOptions.ClientSecret == "" || app_settings.FortnoxOptions.AuthorizationCode == "")
                {
                    // Log the error
                    success = false;
                    LogError("You need to set values in appsettings.json!");
                }
                else if (string.IsNullOrEmpty(app_settings.FortnoxOptions.AccessToken) == true)
                {
                    // Use a http client
                    using (HttpClient http_client = new HttpClient())
                    {
                        // Create options
                        IOptions<FortnoxOptions> options = Options.Create<FortnoxOptions>(new FortnoxOptions
                        {
                            ClientSecret = app_settings.FortnoxOptions.ClientSecret,
                            AuthorizationCode = app_settings.FortnoxOptions.AuthorizationCode
                        });

                        // Create a fortnox authorization client
                        FortnoxAuthorizationClient client = new FortnoxAuthorizationClient(http_client, options);

                        // Get an access token from fortnox
                        Task<AuthorizationResponse> task = client.GetAccessToken();
                        AuthorizationResponse response = task.Result;

                        // Check if the request was a success or not
                        if (response.success == true)
                        {
                            // Set the access token in app settings
                            app_settings.FortnoxOptions.AccessToken = response.message;

                            // Write updated application settings to the file
                            System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(app_settings, Formatting.Indented));
                        }
                        else
                        {
                            // Log the error
                            LogError(response.message);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                // Log the exception
                success = false;
                LogError(ex.ToString());
            }

            // Return the success boolean
            return success;

        } // End of the Run method

        #endregion

        #region Helper methods

        /// <summary>
        /// Log an error
        /// </summary>
        private void LogError(string error)
        {
            // Set the file path
            string path = this.directory + "\\errors.configuration.txt";

            // Add the error message to the file
            System.IO.File.AppendAllText(path, $"{DateTime.Now.ToString("o")} [ERR] {error}" + Environment.NewLine);

        } // End of the LogError method

        #endregion

    } // End of the class

} // End of the namespace