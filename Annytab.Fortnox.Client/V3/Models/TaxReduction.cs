using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for tax reductions
    /// </summary>
    public class TaxReductionsRoot
    {
        #region Variables

        public IList<TaxReduction> TaxReductions { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TaxReductionsRoot()
        {
            this.TaxReductions = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for tax reduction
    /// </summary>
    public class TaxReductionRoot
    {
        #region Variables

        public TaxReduction TaxReduction { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TaxReductionRoot()
        {
            this.TaxReduction = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a tax reduction
    /// </summary>
    public class TaxReduction
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public decimal? AskedAmount { get; set; }
        public decimal? BilledAmount { get; set; }
        public string CustomerName { get; set; }
        public string Id { get; set; }
        public string PropertyDesignation { get; set; }
        public string ReferenceDocumentType { get; set; }
        public string ReferenceNumber { get; set; }
        public bool? RequestSent { get; set; }
        public string ResidenceAssociationOrganisationNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string TypeOfReduction { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TaxReduction()
        {
            // Set values for instance variables
            this.Url = null;
            this.ApprovedAmount = null;
            this.AskedAmount = null;
            this.BilledAmount = null;
            this.CustomerName = null;
            this.Id = null;
            this.PropertyDesignation = null;
            this.ReferenceDocumentType = null;
            this.ReferenceNumber = null;
            this.RequestSent = null;
            this.ResidenceAssociationOrganisationNumber = null;
            this.SocialSecurityNumber = null;
            this.TypeOfReduction = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace