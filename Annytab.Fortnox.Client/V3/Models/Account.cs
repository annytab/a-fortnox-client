using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for accounts
    /// </summary>
    public class AccountsRoot
    {
        #region Variables

        public IList<Account> Accounts { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AccountsRoot()
        {
            this.Accounts = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for account
    /// </summary>
    public class AccountRoot
    {
        #region Variables

        public Account Account { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AccountRoot()
        {
            this.Account = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an account
    /// </summary>
    public class Account
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public bool? Active { get; set; }
        public decimal? BalanceBroughtForward { get; set; }
        public decimal? BalanceCarriedForward { get; set; }
        public string CostCenter { get; set; }
        public string CostCenterSettings { get; set; }
        public string Description { get; set; }
        public string Number { get; set; }
        public string Project { get; set; }
        public string ProjectSettings { get; set; }
        public string SRU { get; set; }
        public string TransactionInformation { get; set; }
        public string TransactionInformationSettings { get; set; }
        public string VATCode { get; set; }
        public string Year { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Account()
        {
            // Set values for instance variables
            this.Url = null;
            this.Active = null;
            this.BalanceBroughtForward = null;
            this.BalanceCarriedForward = null;
            this.CostCenter = null;
            this.CostCenterSettings = null;
            this.Description = null;
            this.Number = null;
            this.Project = null;
            this.ProjectSettings = null;
            this.SRU = null;
            this.TransactionInformation = null;
            this.TransactionInformationSettings = null;
            this.VATCode = null;
            this.Year = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace