namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents default templates for documents
    /// </summary>
    public class DefaultTemplates
    {
        #region Variables

        public string Order { get; set; }
        public string Offer { get; set; }
        public string Invoice { get; set; }
        public string CashInvoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public DefaultTemplates()
        {
            // Set values for instance variables
            this.CashInvoice = "DEFAULTTEMPLATE";
            this.Invoice = "DEFAULTTEMPLATE";
            this.Offer = "DEFAULTTEMPLATE";
            this.Order = "DEFAULTTEMPLATE";

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace