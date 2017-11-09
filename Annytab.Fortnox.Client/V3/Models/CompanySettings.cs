namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for company settings
    /// </summary>
    public class CompanySettingsRoot
    {
        #region Variables

        public CompanySettings CompanySettings { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CompanySettingsRoot()
        {
            this.CompanySettings = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents company settings
    /// </summary>
    public class CompanySettings
    {
        #region Variables

        public string Address { get; set; }
        public string BG { get; set; }
        public string BIC { get; set; }
        public string BranchCode { get; set; }
        public string City { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string DatabaseNumber { get; set; }
        public string Domicile { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }
        public string IBAN { get; set; }
        public string Name { get; set; }
        public string OrganizationNumber { get; set; }
        public string PG { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public bool? TaxEnabled { get; set; }
        public string VATNumber { get; set; }
        public string VisitAddress { get; set; }
        public string VisitCity { get; set; }
        public string VisitCountry { get; set; }
        public string VisitCountryCode { get; set; }
        public string VisitName { get; set; }
        public string VisitZipCode { get; set; }
        public string WWW { get; set; }
        public string ZipCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CompanySettings()
        {
            // Set values for instance variables
            this.Address = null;
            this.BG = null;
            this.BIC = null;
            this.BranchCode = null;
            this.City = null;
            this.ContactFirstName = null;
            this.ContactLastName = null;
            this.Country = null;
            this.CountryCode = null;
            this.DatabaseNumber = null;
            this.Domicile = null;
            this.Email = null;
            this.Fax = null;
            this.IBAN = null;
            this.Name = null;
            this.OrganizationNumber = null;
            this.PG = null;
            this.Phone1 = null;
            this.Phone2 = null;
            this.TaxEnabled = null;
            this.VATNumber = null;
            this.VisitAddress = null;
            this.VisitCity = null;
            this.VisitCountry = null;
            this.VisitCountryCode = null;
            this.VisitName = null;
            this.VisitZipCode = null;
            this.WWW = null;
            this.ZipCode = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace