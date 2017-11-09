using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for predefined accounts
    /// </summary>
    public class PreDefinedAccountsRoot
    {
        #region Variables

        public IList<PreDefinedAccount> PreDefinedAccounts { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PreDefinedAccountsRoot()
        {
            this.PreDefinedAccounts = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for predefined account
    /// </summary>
    public class PreDefinedAccountRoot
    {
        #region Variables

        public PreDefinedAccount PreDefinedAccount { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PreDefinedAccountRoot()
        {
            this.PreDefinedAccount = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a predefined account
    /// </summary>
    public class PreDefinedAccount
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PreDefinedAccount()
        {
            // Set values for instance variables
            this.Url = null;
            this.Account = null;
            this.Name = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace