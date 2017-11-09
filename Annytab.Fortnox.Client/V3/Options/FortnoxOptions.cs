namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represent fortnox options
    /// </summary>
    public class FortnoxOptions
    {
        #region Variables

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string AuthorizationCode { get; set; }
        public string AccessToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FortnoxOptions()
        {
            // Set values for instance variables
            this.ClientId = "";
            this.ClientSecret = "";
            this.AuthorizationCode = "";
            this.AccessToken = "";

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace