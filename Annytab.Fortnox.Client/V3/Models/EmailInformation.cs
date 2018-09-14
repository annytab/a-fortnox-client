namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents email information
    /// </summary>
    public class EmailInformation
    {
        #region Variables

        public string EmailAddressFrom { get; set; }
        public string EmailAddressTo { get; set; }
        public string EmailAddressCC { get; set; }
        public string EmailAddressBCC { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EmailInformation()
        {
            // Set values for instance variables
            this.EmailAddressBCC = null;
            this.EmailAddressCC = null;
            this.EmailAddressFrom = null;
            this.EmailAddressTo = null;
            this.EmailSubject = null;
            this.EmailBody = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace