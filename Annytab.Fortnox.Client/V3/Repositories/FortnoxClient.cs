using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represent a fortnox client
    /// </summary>
    public class FortnoxClient : IFortnoxClient
    {
        #region Variables

        private readonly HttpClient client;
        private readonly FortnoxOptions options;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new repository
        /// </summary>
        public FortnoxClient(HttpClient http_client, IOptions<FortnoxOptions> options)
        {
            // Set values for instance variables
            this.client = http_client;
            this.options = options.Value;

            // Create a http client
            HttpClientHandler handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.None
            };
            this.client = new HttpClient(handler);
            this.client.BaseAddress = new Uri("https://api.fortnox.se/3/");
            this.client.DefaultRequestHeaders.Add("Client-Secret", this.options.ClientSecret);
            this.client.DefaultRequestHeaders.Add("Access-Token", this.options.AccessToken);
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("gzip"));
            this.client.DefaultRequestHeaders.AcceptEncoding.Add(new StringWithQualityHeaderValue("*"));

        } // End of the constructor

        #endregion

        #region Add methods

        /// <summary>
        /// Add a post
        /// </summary>
        public async Task<FortnoxResponse<R>> Add<R>(R root, string uri)
        {
            // Convert the post to json
            string json = JsonConvert.SerializeObject(root, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // Create the response to return
            FortnoxResponse<R> fr = new FortnoxResponse<R>();

            // Send data as application/json data
            using (StringContent content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                try
                {
                    // Get the response
                    HttpResponseMessage response = await this.client.PostAsync(uri, content);

                    // Check the status code for the response
                    if (response.IsSuccessStatusCode == true)
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Deserialize the data
                        fr.model = JsonConvert.DeserializeObject<R>(data);
                    }
                    else
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Add error data
                        fr.error = $"Add: {uri}. {Regex.Unescape(data)}";
                    }
                }
                catch (Exception ex)
                {
                    // Add exception data
                    fr.error = $"Add: {uri}. {ex.ToString()}";
                }
            }

            // Return the response
            return fr;

        } // End of the Add method

        #endregion

        #region Update methods

        /// <summary>
        /// Update a post
        /// </summary>
        public async Task<FortnoxResponse<R>> Update<R>(R root, string uri)
        {
            // Convert the post to json
            string json = JsonConvert.SerializeObject(root, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            // Create the response to return
            FortnoxResponse<R> fr = new FortnoxResponse<R>();

            // Send data as application/json data
            using (StringContent content = new StringContent(json, Encoding.UTF8, "application/json"))
            {
                try
                {
                    // Get the response
                    HttpResponseMessage response = await this.client.PutAsync(uri, content);

                    // Check the status code for the response
                    if (response.IsSuccessStatusCode == true)
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Deserialize the data
                        fr.model = JsonConvert.DeserializeObject<R>(data);
                    }
                    else
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Add error data
                        fr.error = $"Update: {uri}. {Regex.Unescape(data)}";
                    }
                }
                catch (Exception ex)
                {
                    // Add exception data
                    fr.error = $"Update: {uri}. {ex.ToString()}";
                }
            }

            // Return the response
            return fr;

        } // End of the Update method

        /// <summary>
        /// Take an action 
        /// </summary>
        public async Task<FortnoxResponse<R>> Action<R>(string uri)
        {
            // Create the response to return
            FortnoxResponse<R> fr = new FortnoxResponse<R>();

            try
            {
                // Get the response
                HttpResponseMessage response = await this.client.PutAsync(uri, null);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == true)
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Deserialize the data
                    fr.model = JsonConvert.DeserializeObject<R>(data);
                }
                else
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Add error data
                    fr.error = $"Action: {uri}. {Regex.Unescape(data)}";
                }
            }
            catch (Exception ex)
            {
                // Add exception data
                fr.error = $"Action: {uri}. {ex.ToString()}";
            }

            // Return the response
            return fr;

        } // End of the Action method

        #endregion

        #region Get methods

        /// <summary>
        /// Get a list with posts or just a post
        /// </summary>
        public async Task<FortnoxResponse<R>> Get<R>(string uri)
        {
            // Create the response to return
            FortnoxResponse<R> fr = new FortnoxResponse<R>();

            try
            {
                // Get the response
                HttpResponseMessage response = await this.client.GetAsync(uri);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == true)
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Deserialize the data
                    fr.model = JsonConvert.DeserializeObject<R>(data);
                }
                else
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Add error data
                    fr.error = $"Get: {uri}. {Regex.Unescape(data)}";
                }
            }
            catch (Exception ex)
            {
                // Add exception data
                fr.error = $"Get: {uri}. {ex.ToString()}";
            }

            // Return the post
            return fr;

        } // End of the Get method

        #endregion

        #region Delete methods

        /// <summary>
        /// Delete a post
        /// </summary>
        public async Task<FortnoxResponse<bool>> Delete(string uri)
        {
            // Create the response to return
            FortnoxResponse<bool> fr = new FortnoxResponse<bool>();

            // Indicate success
            fr.model = true;

            try
            {
                // Get the response
                HttpResponseMessage response = await this.client.DeleteAsync(uri);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == false)
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Add error data
                    fr.model = false;
                    fr.error = $"Delete: {uri}. {Regex.Unescape(data)}";
                }
            }
            catch (Exception ex)
            {
                // Add exception data
                fr.model = false;
                fr.error = $"Delete: {uri}. {ex.ToString()}";
            }

            // Return the response
            return fr;

        } // End of the Delete method

        #endregion

        #region File methods

        /// <summary>
        /// Upload a file
        /// </summary>
        public async Task<FortnoxResponse<R>> UploadFile<R>(Stream stream, string file_name, string uri)
        {
            // Create the response to return
            FortnoxResponse<R> fr = new FortnoxResponse<R>();

            // Send data as multipart/form-data content
            using (MultipartFormDataContent content = new MultipartFormDataContent())
            {
                // Add content
                content.Add(new StreamContent(stream), "file", file_name);

                try
                {
                    // Get the response
                    HttpResponseMessage response = await this.client.PostAsync(uri, content);

                    // Check the status code for the response
                    if (response.IsSuccessStatusCode == true)
                    {
                        // Get the data
                        string data = await response.Content.ReadAsStringAsync();

                        // Deserialize the data
                        fr.model = JsonConvert.DeserializeObject<R>(data);
                    }
                    else
                    {
                        // Get string data
                        string data = await response.Content.ReadAsStringAsync();

                        // Add error data
                        fr.error = $"UploadFile: {uri}. {Regex.Unescape(data)}";
                    }
                }
                catch (Exception ex)
                {
                    // Add exception data
                    fr.error = $"UploadFile: {uri}. {ex.ToString()}";
                }
            }

            // Return the response
            return fr;

        } // End of the UploadFile method

        /// <summary>
        /// Download a file
        /// </summary>
        public async Task<FortnoxResponse<bool>> DownloadFile(Stream stream, string uri)
        {
            // Create the response to return
            FortnoxResponse<bool> fr = new FortnoxResponse<bool>();

            // Indicate success
            fr.model = true;

            try
            {
                // Get the response
                HttpResponseMessage response = await this.client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

                // Check the status code for the response
                if (response.IsSuccessStatusCode == true)
                {
                    // Get the stream
                    await response.Content.CopyToAsync(stream);
                }
                else
                {
                    // Get string data
                    string data = await response.Content.ReadAsStringAsync();

                    // Add error data
                    fr.model = false;
                    fr.error = $"DownloadFile: {uri}. {Regex.Unescape(data)}";
                }
            }
            catch (Exception ex)
            {
                // Add exception data
                fr.model = false;
                fr.error = $"DownloadFile: {uri}. {ex.ToString()}";
            }

            // Return the response
            return fr;

        } // End of the DownloadFile method

        #endregion

    } // End of the class

} // End of the namespace