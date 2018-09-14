using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for supplier invoices
    /// </summary>
    public class SupplierInvoicesRoot
    {
        #region Variables

        public IList<SupplierInvoice> SupplierInvoices { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoicesRoot()
        {
            this.SupplierInvoices = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for supplier invoice
    /// </summary>
    public class SupplierInvoiceRoot
    {
        #region Variables

        public SupplierInvoice SupplierInvoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceRoot()
        {
            this.SupplierInvoice = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an supplier invoice
    /// </summary>
    public class SupplierInvoice
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public decimal? AdministrationFee { get; set; }
        public decimal? Balance { get; set; }
        public bool? Booked { get; set; }
        public bool? Cancelled { get; set; }
        public string Comments { get; set; }
        public string CostCenter { get; set; }
        public bool? Credit { get; set; }
        public string CreditReference { get; set; }
        public string Currency { get; set; }
        public decimal? CurrencyRate { get; set; }
        public decimal? CurrencyUnit { get; set; }
        public bool? DisablePaymentFile { get; set; }
        public string DueDate { get; set; }
        public string ExternalInvoiceNumber { get; set; }
        public string ExternalInvoiceSeries { get; set; }
        public decimal? Freight { get; set; }
        public string GivenNumber { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string OCR { get; set; }
        public string OurReference { get; set; }
        public bool? PaymentPending { get; set; }
        public string Project { get; set; }
        public decimal? RoundOffValue { get; set; }
        public IList<SupplierInvoiceRow> SupplierInvoiceRows { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierName { get; set; }
        public decimal? Total { get; set; }
        public decimal? VAT { get; set; }
        public string YourReference { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }
        public string VATType { get; set; }
        public string SalesType { get; set; }
        public string AccountingMethod { get; set; }
        public string FinalPayDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoice()
        {
            // Set values for instance variables
            this.Url = null;
            this.AdministrationFee = null;
            this.Balance = null;
            this.Booked = null;
            this.Cancelled = null;
            this.Comments = null;
            this.CostCenter = null;
            this.Credit = null;
            this.CreditReference = null;
            this.Currency = null;
            this.CurrencyRate = null;
            this.CurrencyUnit = null;
            this.DisablePaymentFile = null;
            this.DueDate = null;
            this.ExternalInvoiceNumber = null;
            this.ExternalInvoiceSeries = null;
            this.Freight = null;
            this.GivenNumber = null;
            this.InvoiceDate = null;
            this.InvoiceNumber = null;
            this.OCR = null;
            this.OurReference = null;
            this.PaymentPending = null;
            this.Project = null;
            this.RoundOffValue = null;
            this.SupplierInvoiceRows = null;
            this.SupplierNumber = null;
            this.SupplierName = null;
            this.Total = null;
            this.VAT = null;
            this.YourReference = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;
            this.VATType = null;
            this.SalesType = null;
            this.AccountingMethod = null;
            this.FinalPayDate = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace