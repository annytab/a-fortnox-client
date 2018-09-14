namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents a write off
    /// </summary>
    public class WriteOff
    {
        #region Variables

        public decimal? Amount { get; set; }
        public string AccountNumber { get; set; }
        public string CostCenter { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public string TransactionInformation { get; set; }
        public string Project { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public WriteOff()
        {
            // Set values for instance variables
            this.Amount = null;
            this.AccountNumber = null;
            this.CostCenter = null;
            this.Currency = null;
            this.Description = null;
            this.Project = null;
            this.TransactionInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace