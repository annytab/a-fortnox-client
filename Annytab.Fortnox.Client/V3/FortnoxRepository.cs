using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represent a fortnox repository
    /// </summary>
    public class FortnoxRepository : IFortnoxRepository
    {
        #region Variables

        private readonly ILogger logger;
        private readonly FortnoxOptions options;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new repository
        /// </summary>
        public FortnoxRepository(ILogger<IFortnoxRepository> logger, IOptions<FortnoxOptions> options)
        {
            // Set values for instance variables
            this.logger = logger;
            this.options = options.Value;

        } // End of the constructor

        #endregion

        #region Add methods

        /// <summary>
        /// Add a post
        /// </summary>
        public async Task<R> Add<R>(HttpClient client, R root, string uri)
        {
            // Convert the post to json
            string json = JsonConvert.SerializeObject(root, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // Create the post to return
            R post = default(R);

            // Send data as application/json data
            using (StringContent content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                try
                {
                    // Get the response
                    HttpResponseMessage response = await client.PostAsync(uri, content);

                    // Check the status code for the response
                    if (response.IsSuccessStatusCode == true)
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Deserialize the content 
                        post = JsonConvert.DeserializeObject<R>(data);
                    }
                    else
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Log the error
                        this.logger.LogError($"Add: {uri}. {Regex.Unescape(data)}");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception
                    this.logger.LogError(ex, $"Add: {uri}.", null);
                }
            }

            // Return the post
            return post;

        } // End of the Add method

        #endregion

        #region Update methods

        /// <summary>
        /// Update a post
        /// </summary>
        public async Task<R> Update<R>(HttpClient client, R root, string uri)
        {
            // Convert the post to json
            string json = JsonConvert.SerializeObject(root, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // Create the post to return
            R post = default(R);

            // Send data as application/json data
            using (StringContent content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                try
                {
                    // Get the response
                    HttpResponseMessage response = await client.PutAsync(uri, content);

                    // Check the status code for the response
                    if (response.IsSuccessStatusCode == true)
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Deserialize the content 
                        post = JsonConvert.DeserializeObject<R>(data);
                    }
                    else
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Log the error
                        this.logger.LogError($"Update: {uri}. {Regex.Unescape(data)}");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception
                    this.logger.LogError(ex, $"Update: {uri}.", null);
                }
            }

            // Return the post
            return post;

        } // End of the Update method

        /// <summary>
        /// Take an action 
        /// </summary>
        public async Task<R> Action<R>(HttpClient client, string uri)
        {
            // Create the post to return
            R post = default(R);

            try
            {
                // Get the response
                HttpResponseMessage response = await client.PutAsync(uri, null);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == true)
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Deserialize the data
                    post = JsonConvert.DeserializeObject<R>(data);
                }
                else
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Log the error
                    this.logger.LogError($"Action: {uri}. {Regex.Unescape(data)}");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                this.logger.LogError(ex, $"Action: {uri}.", null);
            }

            // Return the post
            return post;

        } // End of the Action method

        #endregion

        #region Get methods

        /// <summary>
        /// Get a list with posts or just a post
        /// </summary>
        public async Task<R> Get<R>(HttpClient client, string uri)
        {
            // Create the post to return
            R post = default(R);

            try
            {
                // Get the response
                HttpResponseMessage response = await client.GetAsync(uri);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == true)
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Deserialize the data
                    post = JsonConvert.DeserializeObject<R>(data);
                }
                else
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Log the error
                    this.logger.LogError($"Get: {uri}. {Regex.Unescape(data)}");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                this.logger.LogError(ex, $"Get: {uri}.", null);
            }

            // Return the post
            return post;

        } // End of the Get method

        #endregion

        #region Delete methods

        /// <summary>
        /// Delete a post
        /// </summary>
        public async Task<bool> Delete(HttpClient client, string uri)
        {
            try
            {
                // Get the response
                HttpResponseMessage response = await client.DeleteAsync(uri);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == false)
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Log the error
                    this.logger.LogError($"Delete: {uri}. {Regex.Unescape(data)}");

                    // Return false
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                this.logger.LogError(ex, $"Delete: {uri}.", null);

                // Return false
                return false;
            }

            // Return true
            return true;

        } // End of the Delete method

        #endregion

        #region File methods

        /// <summary>
        /// Upload a file
        /// </summary>
        public async Task<R> UploadFile<R>(HttpClient client, Stream stream, string file_name, string uri)
        {
            // Create the post to return
            R post = default(R);

            // Send data as multipart/form-data content
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            {
                // Add content
                content.Add(new StreamContent(stream), "file", file_name);

                try
                {
                    // Get the response
                    HttpResponseMessage response = await client.PostAsync(uri, content);

                    // Check the status code for the response
                    if (response.IsSuccessStatusCode == true)
                    {
                        // Get the data
                        string data = await response.Content.ReadAsStringAsync();

                        // Deserialize the content to File metadata
                        post = JsonConvert.DeserializeObject<R>(data);
                    }
                    else
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Log the error
                        this.logger.LogError($"UploadFile: {uri}. {Regex.Unescape(data)}");
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception
                    this.logger.LogError(ex, $"UploadFile: {uri}.", null);
                }
            }

            // Return the post
            return post;

        } // End of the UploadFile method

        /// <summary>
        /// Download a file
        /// </summary>
        public async Task<bool> DownloadFile(HttpClient client, Stream stream, string uri)
        {
            // Create a success boolean
            bool success = false;

            try
            {
                // Get the response
                HttpResponseMessage response = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == true)
                {
                    // Get the stream
                    await response.Content.CopyToAsync(stream);

                    // Set output variables
                    success = true;
                }
                else
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Log the error
                    this.logger.LogError($"DownloadFile: {uri}. {Regex.Unescape(data)}");
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                this.logger.LogError(ex, $"DownloadFile: {uri}.", null);
            }

            // Return a success boolean
            return success;

        } // End of the DownloadFile method

        #endregion

        #region Connection methods

        /// <summary>
        /// Get a reference to an http client
        /// </summary>
        public HttpClient GetClient()
        {
            // Create a http client
            HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.None
            };
            HttpClient client = new HttpClient(handler);
            client.BaseAddress = new Uri("https://api.fortnox.se/3/");
            client.DefaultRequestHeaders.Add("Client-Secret", this.options.ClientSecret);
            client.DefaultRequestHeaders.Add("Access-Token", this.options.AccessToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("*"));

            // Return the client
            return client;

        } // End of the GetClient method

        /// <summary>
        /// Get an access token from fortnox
        /// </summary>
        public static async Task<AuthorizationResponse> GetAccessToken(string authorization_code, string client_secret)
        {
            // Create the response to return
            AuthorizationResponse post = new AuthorizationResponse();

            // Create a http client
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.fortnox.se/3/");
            client.DefaultRequestHeaders.Add("Authorization-Code", authorization_code);
            client.DefaultRequestHeaders.Add("Client-Secret", client_secret);

            // Get the response
            HttpResponseMessage response = await client.GetAsync("");

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

            // Dispose of the client
            client.Dispose();

            // Return the authorization response
            return post;

        } // End of the GetAccessToken 

        #endregion

    } // End of the class

} // End of the namespace