using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for orders
    /// </summary>
    public class OrdersRoot
    {
        #region Variables

        public IList<Order> Orders { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public OrdersRoot()
        {
            this.Orders = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for order
    /// </summary>
    public class OrderRoot
    {
        #region Variables

        public Order Order { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public OrderRoot()
        {
            this.Order = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an order
    /// </summary>
    public class Order
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        [JsonProperty("@urlTaxReductionList")]
        public string UrlTaxReductionList { get; set; }
        public decimal? AdministrationFee { get; set; }
        public decimal? AdministrationFeeVAT { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public decimal? BasisTaxReduction { get; set; }
        public bool? Cancelled { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public decimal? ContributionPercent { get; set; }
        public decimal? ContributionValue { get; set; }
        public bool? CopyRemarks { get; set; }
        public string Country { get; set; }
        public string CostCenter { get; set; }
        public string Currency { get; set; }
        public decimal? CurrencyRate { get; set; }
        public decimal? CurrencyUnit { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryZipCode { get; set; }
        public string DocumentNumber { get; set; }
        public EmailInformation EmailInformation { get; set; }
        public string ExternalInvoiceReference1 { get; set; }
        public string ExternalInvoiceReference2 { get; set; }
        public decimal? Freight { get; set; }
        public decimal? FreightVAT { get; set; }
        public decimal? Gross { get; set; }
        public bool? HouseWork { get; set; }
        public string InvoiceReference { get; set; }
        public IList<Label> Labels { get; set; }
        public string Language { get; set; }
        public decimal? Net { get; set; }
        public bool? NotCompleted { get; set; }
        public string OfferReference { get; set; }
        public string OrderDate { get; set; }
        public IList<OrderRow> OrderRows { get; set; }
        public string OrderType { get; set; }
        public string OrganisationNumber { get; set; }
        public string OurReference { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PriceList { get; set; }
        public string PrintTemplate { get; set; }
        public string Project { get; set; }
        public bool? WarehouseReady { get; set; }
        public string OutboundDate { get; set; }
        public string Remarks { get; set; }
        public decimal? RoundOff { get; set; }
        public bool? Sent { get; set; }
        public decimal? TaxReduction { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalToPay { get; set; }
        public decimal? TotalVAT { get; set; }
        public bool? VATIncluded { get; set; }
        public string WayOfDelivery { get; set; }
        public string YourReference { get; set; }
        public string YourOrderNumber { get; set; }
        public string ZipCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Order()
        {
            // Set values for instance variables
            this.Url = null;
            this.UrlTaxReductionList = null;
            this.AdministrationFee = null;
            this.AdministrationFeeVAT = null;
            this.Address1 = null;
            this.Address2 = null;
            this.BasisTaxReduction = null;
            this.Cancelled = null;
            this.City = null;
            this.Comments = null;
            this.ContributionPercent = null;
            this.ContributionValue = null;
            this.CopyRemarks = null;
            this.Country = null;
            this.CostCenter = null;
            this.Currency = null;
            this.CurrencyRate = null;
            this.CurrencyUnit = null;
            this.CustomerName = null;
            this.CustomerNumber = null;
            this.DeliveryState = null;
            this.DeliveryAddress1 = null;
            this.DeliveryAddress2 = null;
            this.DeliveryCity = null;
            this.DeliveryCountry = null;
            this.DeliveryDate = null;
            this.DeliveryName = null;
            this.DeliveryZipCode = null;
            this.DocumentNumber = null;
            this.EmailInformation = null;
            this.ExternalInvoiceReference1 = null;
            this.ExternalInvoiceReference2 = null;
            this.Freight = null;
            this.FreightVAT = null;
            this.Gross = null;
            this.HouseWork = null;
            this.InvoiceReference = null;
            this.Labels = null;
            this.Language = null;
            this.Net = null;
            this.NotCompleted = null;
            this.OfferReference = null;
            this.OrderDate = null;
            this.OrderRows = null;
            this.OrderType = null;
            this.OrganisationNumber = null;
            this.OurReference = null;
            this.Phone1 = null;
            this.Phone2 = null;
            this.PriceList = null;
            this.PrintTemplate = null;
            this.Project = null;
            this.WarehouseReady = null;
            this.OutboundDate = null;
            this.Remarks = null;
            this.RoundOff = null;
            this.Sent = null;
            this.TaxReduction = null;
            this.TermsOfDelivery = null;
            this.TermsOfPayment = null;
            this.Total = null;
            this.TotalToPay = null;
            this.TotalVAT = null;
            this.VATIncluded = null;
            this.WayOfDelivery = null;
            this.YourReference = null;
            this.YourOrderNumber = null;
            this.ZipCode = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace