using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This interface represent a fortnox repository
    /// </summary>
    public interface IFortnoxRepository
    {
        /// <summary>
        /// Add a post
        /// </summary>
        Task<R> Add<R>(HttpClient client, R root, string uri);

        /// <summary>
        /// Update a post
        /// </summary>
        Task<R> Update<R>(HttpClient client, R root, string uri);

        /// <summary>
        /// Take an action 
        /// </summary>
        Task<R> Action<R>(HttpClient client, string uri);

        /// <summary>
        /// Get a list with posts or just a post
        /// </summary>
        Task<R> Get<R>(HttpClient client, string uri);

        /// <summary>
        /// Delete a post
        /// </summary>
        Task<bool> Delete(HttpClient client, string uri);

        /// <summary>
        /// Upload a file
        /// </summary>
        Task<R> UploadFile<R>(HttpClient client, Stream stream, string file_name, string uri);

        /// <summary>
        /// Download a file
        /// </summary>
        Task<bool> DownloadFile(HttpClient client, Stream stream, string uri);

        /// <summary>
        /// Get a reference to an http client
        /// </summary>
        HttpClient GetClient();

    } // End of the interface

} // End of the namespace