using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for suppliers
    /// </summary>
    public class SuppliersRoot
    {
        #region Variables

        public IList<Supplier> Suppliers { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SuppliersRoot()
        {
            this.Suppliers = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for supplier
    /// </summary>
    public class SupplierRoot
    {
        #region Variables

        public Supplier Supplier { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierRoot()
        {
            this.Supplier = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a supplier
    /// </summary>
    public class Supplier
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public bool? Active { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Bank { get; set; }
        public string BankAccountNumber { get; set; }
        public string BG { get; set; }
        public string BIC { get; set; }
        public string BranchCode { get; set; }
        public string City { get; set; }
        public string ClearingNumber { get; set; }
        public string Comments { get; set; }
        public string CostCenter { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Currency { get; set; }
        public bool? DisablePaymentFile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string IBAN { get; set; }
        public string Name { get; set; }
        public string OrganisationNumber { get; set; }
        public string OurReference { get; set; }
        public string OurCustomerNumber { get; set; }
        public string PG { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PreDefinedAccount { get; set; }
        public string Project { get; set; }
        public string SupplierNumber { get; set; }
        public string TermsOfPayment { get; set; }
        public string VATNumber { get; set; }
        public string VATType { get; set; }
        public string VisitingAddress { get; set; }
        public string VisitingCity { get; set; }
        public string VisitingCountry { get; set; }
        public string VisitingCountryCode { get; set; }
        public string VisitingZipCode { get; set; }
        public string WorkPlace { get; set; }
        public string WWW { get; set; }
        public string YourReference { get; set; }
        public string ZipCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Supplier()
        {
            this.Url = null;
            this.Active = null;
            this.Address1 = null;
            this.Address2 = null;
            this.Bank = null;
            this.BankAccountNumber = null;
            this.BG = null;
            this.BIC = null;
            this.BranchCode = null;
            this.City = null;
            this.ClearingNumber = null;
            this.Comments = null;
            this.CostCenter = null;
            this.Country = null;
            this.CountryCode = null;
            this.Currency = null;
            this.DisablePaymentFile = null;
            this.Email = null;
            this.Fax = null;
            this.IBAN = null;
            this.Name = null;
            this.OrganisationNumber = null;
            this.OurReference = null;
            this.OurCustomerNumber = null;
            this.PG = null;
            this.Phone1 = null;
            this.Phone2 = null;
            this.PreDefinedAccount = null;
            this.Project = null;
            this.SupplierNumber = null;
            this.TermsOfPayment = null;
            this.VATNumber = null;
            this.VATType = null;
            this.VisitingAddress = null;
            this.VisitingCity = null;
            this.VisitingCountry = null;
            this.VisitingCountryCode = null;
            this.VisitingZipCode = null;
            this.WorkPlace = null;
            this.WWW = null;
            this.YourReference = null;
            this.ZipCode = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace