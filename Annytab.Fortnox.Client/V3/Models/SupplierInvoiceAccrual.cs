using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for supplier invoice accruals
    /// </summary>
    public class SupplierInvoiceAccrualsRoot
    {
        #region Variables

        public IList<SupplierInvoiceAccrual> SupplierInvoiceAccruals { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceAccrualsRoot()
        {
            this.SupplierInvoiceAccruals = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for supplier invoice accrual
    /// </summary>
    public class SupplierInvoiceAccrualRoot
    {
        #region Variables

        public SupplierInvoiceAccrual SupplierInvoiceAccrual { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceAccrualRoot()
        {
            this.SupplierInvoiceAccrual = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an supplier invoice accrual
    /// </summary>
    public class SupplierInvoiceAccrual
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string AccrualAccount { get; set; }
        public string CostAccount { get; set; }
        public string Description { get; set; }
        public string EndDate { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public string Period { get; set; }
        public IList<AccrualRow> SupplierInvoiceAccrualRows { get; set; }
        public string StartDate { get; set; }
        public Int32? Times { get; set; }
        public decimal? Total { get; set; }
        public bool? VATIncluded { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceAccrual()
        {
            // Set values for instance variables
            this.Url = null;
            this.AccrualAccount = null;
            this.CostAccount = null;
            this.Description = null;
            this.EndDate = null;
            this.SupplierInvoiceNumber = null;
            this.Period = null;
            this.SupplierInvoiceAccrualRows = null;
            this.StartDate = null;
            this.Times = null;
            this.Total = null;
            this.VATIncluded = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace