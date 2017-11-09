using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for contract templates
    /// </summary>
    public class ContractTemplatesRoot
    {
        #region Variables

        public IList<ContractTemplate> ContractTemplates { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractTemplatesRoot()
        {
            this.ContractTemplates = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for contract templates
    /// </summary>
    public class ContractTemplateRoot
    {
        #region Variables

        public ContractTemplate ContractTemplate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractTemplateRoot()
        {
            this.ContractTemplate = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a contract template
    /// </summary>
    public class ContractTemplate
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public decimal? AdministrationFee { get; set; }
        public Int32? ContractLength { get; set; }
        public decimal? Freight { get; set; }
        public Int32? InvoiceInterval { get; set; }
        public IList<InvoiceRow> InvoiceRows { get; set; }
        public bool? Continuous { get; set; }
        public string OurReference { get; set; }
        public string PrintTemplate { get; set; }
        public string Remarks { get; set; }
        public string TemplateName { get; set; }
        public string TemplateNumber { get; set; }
        public string TermsOfDelivery { get; set; }
        public string TermsOfPayment { get; set; }
        public string WayOfDelivery { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ContractTemplate()
        {
            // Set values for instance variables
            this.Url = null;
            this.AdministrationFee = null;
            this.ContractLength = null;
            this.Freight = null;
            this.InvoiceInterval = null;
            this.InvoiceRows = null;
            this.Continuous = null;
            this.OurReference = null;
            this.PrintTemplate = null;
            this.Remarks = null;
            this.TemplateName = null;
            this.TemplateNumber = null;
            this.TermsOfDelivery = null;
            this.TermsOfPayment = null;
            this.WayOfDelivery = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace