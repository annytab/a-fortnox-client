namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents edi information
    /// </summary>
    public class EDIInformation
    {
        #region Variables

        public string EDIGlobalLocationNumber { get; set; }
        public string EDIGlobalLocationNumberDelivery { get; set; }
        public string EDIInvoiceExtra1 { get; set; }
        public string EDIInvoiceExtra2 { get; set; }
        public string EDIOurElectronicReference { get; set; }
        public string EDIYourElectronicReference { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EDIInformation()
        {
            // Set values for instance variables
            this.EDIGlobalLocationNumber = null;
            this.EDIGlobalLocationNumberDelivery = null;
            this.EDIInvoiceExtra1 = null;
            this.EDIInvoiceExtra2 = null;
            this.EDIOurElectronicReference = null;
            this.EDIYourElectronicReference = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace