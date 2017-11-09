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
        Task<R> Add<R>(HttpClient client, R root, string uri);
        Task<R> Update<R>(HttpClient client, R root, string uri);
        Task<R> Action<R>(HttpClient client, string uri);
        Task<R> Get<R>(HttpClient client, string uri);
        Task<bool> Delete(HttpClient client, string uri);
        Task<R> UploadFile<R>(HttpClient client, Stream stream, string file_name, string uri);
        Task DownloadFile(HttpClient client, Stream stream, string uri);
        HttpClient GetClient();

    } // End of the interface

} // End of the namespace