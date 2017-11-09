using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for invoice accruals
    /// </summary>
    public class InvoiceAccrualsRoot
    {
        #region Variables

        public IList<InvoiceAccrual> InvoiceAccruals { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoiceAccrualsRoot()
        {
            this.InvoiceAccruals = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for invoice accrual
    /// </summary>
    public class InvoiceAccrualRoot
    {
        #region Variables

        public InvoiceAccrual InvoiceAccrual { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoiceAccrualRoot()
        {
            this.InvoiceAccrual = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an invoice accrual
    /// </summary>
    public class InvoiceAccrual
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string AccrualAccount { get; set; }
        public string Description { get; set; }
        public string EndDate { get; set; }
        public IList<AccrualRow> InvoiceAccrualRows { get; set; }
        public string InvoiceNumber { get; set; }
        public string Period { get; set; }
        public string RevenueAccount { get; set; }
        public string StartDate { get; set; }
        public Int32? Times { get; set; }
        public decimal? Total { get; set; }
        public bool? VATIncluded { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoiceAccrual()
        {
            // Set values for instance variables
            this.Url = null;
            this.AccrualAccount = null;
            this.Description = null;
            this.EndDate = null;
            this.InvoiceAccrualRows = null;
            this.InvoiceNumber = null;
            this.Period = null;
            this.RevenueAccount = null;
            this.StartDate = null;
            this.Times = null;
            this.Total = null;
            this.VATIncluded = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace