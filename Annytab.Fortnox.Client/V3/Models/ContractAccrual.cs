using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for contract accruals
    /// </summary>
    public class ContractAccrualsRoot
    {
        #region Variables

        public IList<ContractAccrual> ContractAccruals { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractAccrualsRoot()
        {
            // Set values for instance variables
            this.ContractAccruals = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for contract accrual
    /// </summary>
    public class ContractAccrualRoot
    {
        #region Variables

        public ContractAccrual ContractAccrual { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractAccrualRoot()
        {
            this.ContractAccrual = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a contract accrual
    /// </summary>
    public class ContractAccrual
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string AccrualAccount { get; set; }
        public string CostAccount { get; set; }
        public string Description { get; set; }
        public IList<AccrualRow> AccrualRows { get; set; }
        public string DocumentNumber { get; set; }
        public string Period { get; set; }
        public Int32? Times { get; set; }
        public decimal? Total { get; set; }
        public bool? VATIncluded { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractAccrual()
        {
            // Set values for instance variables
            this.Url = null;
            this.AccrualAccount = null;
            this.CostAccount = null;
            this.Description = null;
            this.AccrualRows = null;
            this.DocumentNumber = null;
            this.Period = null;
            this.Times = null;
            this.Total = null;
            this.VATIncluded = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace