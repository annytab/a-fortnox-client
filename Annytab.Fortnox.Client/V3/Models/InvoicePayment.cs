using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for invoice payments
    /// </summary>
    public class InvoicePaymentsRoot
    {
        #region Variables

        public IList<InvoicePayment> InvoicePayments { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoicePaymentsRoot()
        {
            this.InvoicePayments = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for invoice payment
    /// </summary>
    public class InvoicePaymentRoot
    {
        #region Variables

        public InvoicePayment InvoicePayment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoicePaymentRoot()
        {
            this.InvoicePayment = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a invoice payment
    /// </summary>
    public class InvoicePayment
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
        public string ExternalInvoiceReference1 { get; set; }
        public string ExternalInvoiceReference2 { get; set; }
        public string InvoiceCustomerName { get; set; }
        public string InvoiceCustomerNumber { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceDueDate { get; set; }
        public string InvoiceOCR { get; set; }
        public decimal? InvoiceTotal { get; set; }
        public string ModeOfPayment { get; set; }
        public string Number { get; set; }
        public string PaymentDate { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }
        public string Source { get; set; }
        public IList<WriteOff> WriteOffs { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoicePayment()
        {
            // Set values for instance variables
            this.Url = null;
            this.Amount = null;
            this.AmountCurrency = null;
            this.Booked = null;
            this.Currency = null;
            this.CurrencyRate = null;
            this.CurrencyUnit = null;
            this.ExternalInvoiceReference1 = null;
            this.ExternalInvoiceReference2 = null;
            this.InvoiceCustomerName = null;
            this.InvoiceCustomerNumber = null;
            this.InvoiceNumber = null;
            this.InvoiceDueDate = null;
            this.InvoiceOCR = null;
            this.InvoiceTotal = null;
            this.ModeOfPayment = null;
            this.Number = null;
            this.PaymentDate = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;
            this.Source = null;
            this.WriteOffs = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace