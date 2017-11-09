using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for supplier invoice payments
    /// </summary>
    public class SupplierInvoicePaymentsRoot
    {
        #region Variables

        public IList<SupplierInvoicePayment> SupplierInvoicePayments { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoicePaymentsRoot()
        {
            this.SupplierInvoicePayments = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for supplier invoice payment
    /// </summary>
    public class SupplierInvoicePaymentRoot
    {
        #region Variables

        public SupplierInvoicePayment SupplierInvoicePayment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoicePaymentRoot()
        {
            this.SupplierInvoicePayment = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a supplier invoice payment
    /// </summary>
    public class SupplierInvoicePayment
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public decimal? Amount { get; set; }
        public decimal? AmountCurrency { get; set; }
        public bool? Booked { get; set; }
        public string Currency { get; set; }
        public decimal? CurrencyRate { get; set; }
        public decimal? CurrencyUnit { get; set; }
        public string Information { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceDueDate { get; set; }
        public string InvoiceOCR { get; set; }
        public string InvoiceSupplierName { get; set; }
        public string InvoiceSupplierNumber { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public string ModeOfPayment { get; set; }
        public string Number { get; set; }
        public string PaymentDate { get; set; }
        public string Source { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }
        public List<WriteOff> WriteOffs { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoicePayment()
        {
            // Set values for instance variables
            this.Url = null;
            this.Amount = null;
            this.AmountCurrency = null;
            this.Booked = null;
            this.Currency = null;
            this.CurrencyRate = null;
            this.CurrencyUnit = null;
            this.Information = null;
            this.InvoiceNumber = null;
            this.InvoiceDueDate = null;
            this.InvoiceOCR = null;
            this.InvoiceSupplierName = null;
            this.InvoiceSupplierNumber = null;
            this.InvoiceTotal = null;
            this.ModeOfPayment = null;
            this.Number = null;
            this.PaymentDate = null;
            this.Source = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;
            this.WriteOffs = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace