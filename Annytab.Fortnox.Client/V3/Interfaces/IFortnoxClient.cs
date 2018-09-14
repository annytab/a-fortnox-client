using System.IO;
using System.Threading.Tasks;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This interface represent a fortnox client
    /// </summary>
    public interface IFortnoxClient
    {
        /// <summary>
        /// Add a post
        /// </summary>
        Task<FortnoxResponse<R>> Add<R>(R root, string uri);

        /// <summary>
        /// Update a post
        /// </summary>
        Task<FortnoxResponse<R>> Update<R>(R root, string uri);

        /// <summary>
        /// Take an action 
        /// </summary>
        Task<FortnoxResponse<R>> Action<R>(string uri);

        /// <summary>
        /// Get a list with posts or just a post
        /// </summary>
        Task<FortnoxResponse<R>> Get<R>(string uri);

        /// <summary>
        /// Delete a post
        /// </summary>
        Task<FortnoxResponse<bool>> Delete(string uri);

        /// <summary>
        /// Upload a file
        /// </summary>
        Task<FortnoxResponse<R>> UploadFile<R>(Stream stream, string file_name, string uri);

        /// <summary>
        /// Download a file
        /// </summary>
        Task<FortnoxResponse<bool>> DownloadFile(Stream stream, string uri);

    } // End of the interface

} // End of the namespace