namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// A response with an access token or an error message
    /// </summary>
    public class AuthorizationResponse
    {
        #region Variables

        public bool success;
        public string message;

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AuthorizationResponse()
        {
            // Set values for instance variables
            this.success = false;
            this.message = "";

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for authorization
    /// </summary>
    public class AuthorizationRoot
    {
        #region Variables

        public Authorization Authorization { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AuthorizationRoot()
        {
            this.Authorization = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represent authorization
    /// </summary>
    public class Authorization
    {
        #region Variables

        public string AccessToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Authorization()
        {
            // Set values for instance variables
            this.AccessToken = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace
