using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for invoices
    /// </summary>
    public class InvoicesRoot
    {
        #region Variables

        public IList<Invoice> Invoices { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoicesRoot()
        {
            this.Invoices = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for invoice
    /// </summary>
    public class InvoiceRoot
    {
        #region Variables

        public Invoice Invoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public InvoiceRoot()
        {
            this.Invoice = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an invoice
    /// </summary>
    public class Invoice
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        [JsonProperty("@urlTaxReductionList")]
        public string UrlTaxReductionList { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public decimal? AdministrationFee { get; set; }
        public decimal? AdministrationFeeVAT { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BasisTaxReduction { get; set; }
        public bool? Booked { get; set; }
        public bool? Cancelled { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string ContractReference { get; set; }
        public decimal? ContributionPercent { get; set; }
        public decimal? ContributionValue { get; set; }
        public string CostCenter { get; set; }
        public string Country { get; set; }
        public bool? Credit { get; set; }
        public string CreditInvoiceReference { get; set; }
        public string Currency { get; set; }
        public decimal? CurrencyRate { get; set; }
        public decimal? CurrencyUnit { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryZipCode { get; set; }
        public string DocumentNumber { get; set; }
        public string DueDate { get; set; }
        public EDIInformation EDIInformation { get; set; }
        public bool? EUQuarterlyReport { get; set; }
        public EmailInformation EmailInformation { get; set; }
        public string ExternalInvoiceReference1 { get; set; }
        public string ExternalInvoiceReference2 { get; set; }
        public decimal? Freight { get; set; }
        public decimal? FreightVAT { get; set; }
        public decimal? Gross { get; set; }
        public bool? HouseWork { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoicePeriodEnd { get; set; }
        public string InvoicePeriodStart { get; set; }
        public string InvoiceReference { get; set; }
        public IList<InvoiceRow> InvoiceRows { get; set; }
        public string InvoiceType { get; set; }
        public IList<Label> Labels { get; set; }
        public string Language { get; set; }
        public string LastRemindDate { get; set; }
        public decimal? Net { get; set; }
        public bool? NotCompleted { get; set; }
        public bool? NoxFinans { get; set; }
        public string OCR { get; set; }
        public string OfferReference { get; set; }
        public string OrderReference { get; set; }
        public string OrganisationNumber { get; set; }
        public string OurReference { get; set; }
        public string PaymentWay { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PriceList { get; set; }
        public string PrintTemplate { get; set; }
        public string Project { get; set; }
        public bool? WarehouseReady { get; set; }
        public string OutboundDate { get; set; }
        public string Remarks { get; set; }
        public Int32? Reminders { get; set; }
        public decimal? RoundOff { get; set; }
        public bool? Sent { get; set; }
        public decimal? TaxReduction { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalToPay { get; set; }
        public decimal? TotalVAT { get; set; }
        public bool? VATIncluded { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }
        public string WayOfDelivery { get; set; }
        public string YourOrderNumber { get; set; }
        public string YourReference { get; set; }
        public string ZipCode { get; set; }
        public string AccountingMethod { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Invoice()
        {
            // Set values for instance variables
            this.Url = null;
            this.UrlTaxReductionList = null;
            this.Address1 = null;
            this.Address2 = null;
            this.AdministrationFee = null;
            this.AdministrationFeeVAT = null;
            this.Balance = null;
            this.BasisTaxReduction = null;
            this.Booked = null;
            this.Cancelled = null;
            this.City = null;
            this.Comments = null;
            this.ContractReference = null;
            this.ContributionPercent = null;
            this.ContributionValue = null;
            this.CostCenter = null;
            this.Country = null;
            this.Credit = null;
            this.CreditInvoiceReference = null;
            this.Currency = null;
            this.CurrencyRate = null;
            this.CurrencyUnit = null;
            this.CustomerName = null;
            this.CustomerNumber = null;
            this.DeliveryAddress1 = null;
            this.DeliveryAddress2 = null;
            this.DeliveryCity = null;
            this.DeliveryCountry = null;
            this.DeliveryDate = null;
            this.DeliveryName = null;
            this.DeliveryZipCode = null;
            this.DocumentNumber = null;
            this.DueDate = null;
            this.EDIInformation = null;
            this.EUQuarterlyReport = null;
            this.EmailInformation = null;
            this.ExternalInvoiceReference1 = null;
            this.ExternalInvoiceReference2 = null;
            this.Freight = null;
            this.FreightVAT = null;
            this.Gross = null;
            this.HouseWork = null;
            this.InvoiceDate = null;
            this.InvoicePeriodEnd = null;
            this.InvoicePeriodStart = null;
            this.InvoiceReference = null;
            this.InvoiceRows = null;
            this.InvoiceType = null;
            this.Labels = null;
            this.Language = null;
            this.LastRemindDate = null;
            this.Net = null;
            this.NotCompleted = null;
            this.NoxFinans = null;
            this.OCR = null;
            this.OfferReference = null;
            this.OrderReference = null;
            this.OrganisationNumber = null;
            this.OurReference = null;
            this.PaymentWay = null;
            this.Phone1 = null;
            this.Phone2 = null;
            this.PriceList = null;
            this.PrintTemplate = null;
            this.Project = null;
            this.WarehouseReady = null;
            this.OutboundDate = null;
            this.Remarks = null;
            this.Reminders = null;
            this.RoundOff = null;
            this.Sent = null;
            this.TaxReduction = null;
            this.TermsOfDelivery = null;
            this.TermsOfPayment = null;
            this.Total = null;
            this.TotalToPay = null;
            this.TotalVAT = null;
            this.VATIncluded = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;
            this.WayOfDelivery = null;
            this.YourOrderNumber = null;
            this.YourReference = null;
            this.ZipCode = null;
            this.AccountingMethod = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace