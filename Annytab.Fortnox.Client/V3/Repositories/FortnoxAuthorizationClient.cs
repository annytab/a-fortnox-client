using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represent a fortnox authorization client
    /// </summary>
    public class FortnoxAuthorizationClient : IFortnoxAuthorizationClient
    {
        #region Variables

        private readonly HttpClient client;
        private readonly FortnoxOptions options;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new repository
        /// </summary>
        public FortnoxAuthorizationClient(HttpClient http_client, IOptions<FortnoxOptions> options)
        {
            // Set values for instance variables
            this.client = http_client;
            this.options = options.Value;

            // Set values for the client
            this.client.BaseAddress = new Uri("https://api.fortnox.se/3/");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.client.DefaultRequestHeaders.Add("Client-Secret", this.options.ClientSecret);
            this.client.DefaultRequestHeaders.Add("Authorization-Code", this.options.AuthorizationCode);

        } // End of the constructor

        #endregion

        #region Get methods

        /// <summary>
        /// Get an access token from fortnox
        /// </summary>
        public async Task<AuthorizationResponse> GetAccessToken()
        {
            // Create the response to return
            AuthorizationResponse post = new AuthorizationResponse();

            // Get the response
            HttpResponseMessage response = await this.client.GetAsync("");

            // Check the status code for the response
            if (response.IsSuccessStatusCode == true)
            {
                // Get the access token
                string data = await response.Content.ReadAsStringAsync();
                AuthorizationRoot root = JsonConvert.DeserializeObject<AuthorizationRoot>(data);

                // Add the access token to the response
                post.success = true;
                post.message = root.Authorization.AccessToken;
            }
            else
            {
                // Get the error message
                string data = await response.Content.ReadAsStringAsync();

                // Add the error to the response
                post.success = false;
                post.message = Regex.Unescape(data);
            }

            // Return the authorization response
            return post;

        } // End of the GetAccessToken 

        #endregion

    } // End of the class

} // End of the namespace