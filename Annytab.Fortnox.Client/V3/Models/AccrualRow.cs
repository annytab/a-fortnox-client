namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents an accrual row
    /// </summary>
    public class AccrualRow
    {
        #region Variables

        public string Account { get; set; }
        public string CostCenter { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string Project { get; set; }
        public string TransactionInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AccrualRow()
        {
            // Set values for instance variables
            this.Account = null;
            this.CostCenter = null;
            this.Credit = null;
            this.Debit = null;
            this.Project = null;
            this.TransactionInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace