namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents default delivery types for documents
    /// </summary>
    public class DefaultDeliveryTypes
    {
        #region Variables

        public string Invoice { get; set; }
        public string Order { get; set; }
        public string Offer { get; set; }
        
        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public DefaultDeliveryTypes()
        {
            // Set values for instance variables
            this.Invoice = "PRINT";
            this.Offer = "PRINT";
            this.Order = "PRINT";

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace