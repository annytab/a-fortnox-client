using System.Threading.Tasks;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This interface represent a fortnox authorization client
    /// </summary>
    public interface IFortnoxAuthorizationClient
    {
        /// <summary>
        /// Get an access token from fortnox
        /// </summary>
        Task<AuthorizationResponse> GetAccessToken();

    } // End of the interface

} // End of the namespace