using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for customers
    /// </summary>
    public class CustomersRoot
    {
        #region Variables

        public IList<Customer> Customers { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CustomersRoot()
        {
            this.Customers = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for customer
    /// </summary>
    public class CustomerRoot
    {
        #region Variables

        public Customer Customer { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CustomerRoot()
        {
            this.Customer = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a customer
    /// </summary>
    public class Customer
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public bool? Active { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Comments { get; set; }
        public string CostCenter { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Currency { get; set; }
        public string CustomerNumber { get; set; }
        public DefaultDeliveryTypes DefaultDeliveryTypes { get; set; }
        public DefaultTemplates DefaultTemplates { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryCountryCode { get; set; }
        public string DeliveryFax { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryPhone1 { get; set; }
        public string DeliveryPhone2 { get; set; }
        public string DeliveryZipCode { get; set; }
        public string Email { get; set; }
        public string EmailInvoice { get; set; }
        public string EmailInvoiceBCC { get; set; }
        public string EmailInvoiceCC { get; set; }
        public string EmailOffer { get; set; }
        public string EmailOfferBCC { get; set; }
        public string EmailOfferCC { get; set; }
        public string EmailOrder { get; set; }
        public string EmailOrderBCC { get; set; }
        public string EmailOrderCC { get; set; }
        public string Fax { get; set; }
        public string GLN { get; set; }
        public string GLNDelivery { get; set; }
        public decimal? InvoiceAdministrationFee { get; set; }
        public decimal? InvoiceDiscount { get; set; }
        public decimal? InvoiceFreight { get; set; }
        public string InvoiceRemark { get; set; }
        public string Name { get; set; }
        public string OrganisationNumber { get; set; }
        public string OurReference { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PriceList { get; set; }
        public string Project { get; set; }
        public string SalesAccount { get; set; }
        public bool? ShowPriceVATIncluded { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public string Type { get; set; }
        public string VATNumber { get; set; }
        public string VATType { get; set; }
        public string VisitingAddress { get; set; }
        public string VisitingCity { get; set; }
        public string VisitingCountry { get; set; }
        public string VisitingCountryCode { get; set; }
        public string VisitingZipCode { get; set; }
        public string WWW { get; set; }
        public string WayOfDelivery { get; set; }
        public string YourReference { get; set; }
        public string ZipCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Customer()
        {
            // Set values for instance variables
            this.Url = null;
            this.Active = null;
            this.Address1 = null;
            this.Address2 = null;
            this.City = null;
            this.Comments = null;
            this.CostCenter = null;
            this.Country = null;
            this.CountryCode = null;
            this.Currency = null;
            this.CustomerNumber = null;
            this.DefaultDeliveryTypes = null;
            this.DefaultTemplates = null;
            this.DeliveryAddress1 = null;
            this.DeliveryAddress2 = null;
            this.DeliveryCity = null;
            this.DeliveryCountry = null;
            this.DeliveryCountryCode = null;
            this.DeliveryFax = null;
            this.DeliveryName = null;
            this.DeliveryPhone1 = null;
            this.DeliveryPhone2 = null;
            this.DeliveryZipCode = null;
            this.Email = null;
            this.EmailInvoice = null;
            this.EmailInvoiceBCC = null;
            this.EmailInvoiceCC = null;
            this.EmailOffer = null;
            this.EmailOfferBCC = null;
            this.EmailOfferCC = null;
            this.EmailOrder = null;
            this.EmailOrderBCC = null;
            this.EmailOrderCC = null;
            this.Fax = null;
            this.GLN = null;
            this.GLNDelivery = null;
            this.InvoiceAdministrationFee = null;
            this.InvoiceDiscount = null;
            this.InvoiceFreight = null;
            this.InvoiceRemark = null;
            this.Name = null;
            this.OrganisationNumber = null;
            this.OurReference = null;
            this.Phone1 = null;
            this.Phone2 = null;
            this.PriceList = null;
            this.Project = null;
            this.SalesAccount = null;
            this.ShowPriceVATIncluded = null;
            this.TermsOfDelivery = null;
            this.TermsOfPayment = null;
            this.Type = null;
            this.VATNumber = null;
            this.VATType = null;
            this.VisitingAddress = null;
            this.VisitingCity = null;
            this.VisitingCountry = null;
            this.VisitingCountryCode = null;
            this.VisitingZipCode = null;
            this.WWW = null;
            this.WayOfDelivery = null;
            this.YourReference = null;
            this.ZipCode = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace