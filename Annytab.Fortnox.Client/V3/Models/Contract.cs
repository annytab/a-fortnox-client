using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for contracts
    /// </summary>
    public class ContractsRoot
    {
        #region Variables

        public IList<Contract> Contracts { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractsRoot()
        {
            this.Contracts = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for contract
    /// </summary>
    public class ContractRoot
    {
        #region Variables

        public Contract Contract { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractRoot()
        {
            this.Contract = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a contract
    /// </summary>
    public class Contract
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        [JsonProperty("@urlTaxReductionList")]
        public string UrlTaxReductionList { get; set; }
        public bool? Active { get; set; }
        public decimal? AdministrationFee { get; set; }
        public string Comments { get; set; }
        public bool? Continuous { get; set; }
        public string ContractDate { get; set; }
        public Int32? ContractLength { get; set; }
        public decimal? ContributionPercent { get; set; }
        public decimal? ContributionValue { get; set; }
        public string CostCenter { get; set; }
        public string Currency { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string DocumentNumber { get; set; }
        public EmailInformation EmailInformation { get; set; }
        public string ExternalInvoiceReference1 { get; set; }
        public string ExternalInvoiceReference2 { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Gross { get; set; }
        public bool? HouseWork { get; set; }
        public decimal? InvoiceDiscount { get; set; }
        public Int32? InvoiceInterval { get; set; }
        public Int32? InvoicesRemaining { get; set; }
        public IList<InvoiceRow> InvoiceRows { get; set; }
        public string Language { get; set; }
        public string LastInvoiceDate { get; set; }
        public decimal? Net { get; set; }
        public string OurReference { get; set; }
        public string PeriodEnd { get; set; }
        public string PeriodStart { get; set; }
        public string PriceList { get; set; }
        public string PrintTemplate { get; set; }
        public string Project { get; set; }
        public string Remarks { get; set; }
        public decimal? TaxReduction { get; set; }
        public string TemplateName { get; set; }
        public string TemplateNumber { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalToPay { get; set; }
        public decimal? TotalVAT { get; set; }
        public bool? VATIncluded { get; set; }
        public string WayOfDelivery { get; set; }
        public string YourOrderNumber { get; set; }
        public string YourReference { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Contract()
        {
            // Set values for instance variables
            this.Url = null;
            this.UrlTaxReductionList = null;
            this.Active = null;
            this.AdministrationFee = null;
            this.Comments = null;
            this.Continuous = null;
            this.ContractDate = null;
            this.ContractLength = null;
            this.ContributionPercent = null;
            this.ContributionValue = null;
            this.CostCenter = null;
            this.Currency = null;
            this.CustomerName = null;
            this.CustomerNumber = null;
            this.DocumentNumber = null;
            this.EmailInformation = null;
            this.ExternalInvoiceReference1 = null;
            this.ExternalInvoiceReference2 = null;
            this.Freight = null;
            this.Gross = null;
            this.HouseWork = null;
            this.InvoiceDiscount = null;
            this.InvoiceInterval = null;
            this.InvoicesRemaining = null;
            this.InvoiceRows = null;
            this.Language = null;
            this.LastInvoiceDate = null;
            this.Net = null;
            this.OurReference = null;
            this.PeriodEnd = null;
            this.PeriodStart = null;
            this.PriceList = null;
            this.PrintTemplate = null;
            this.Project = null;
            this.Remarks = null;
            this.TaxReduction = null;
            this.TemplateName = null;
            this.TemplateNumber = null;
            this.TermsOfDelivery = null;
            this.TermsOfPayment = null;
            this.Total = null;
            this.TotalToPay = null;
            this.TotalVAT = null;
            this.VATIncluded = null;
            this.WayOfDelivery = null;
            this.YourOrderNumber = null;
            this.YourReference = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace