namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents an voucher row
    /// </summary>
    public class VoucherRow
    {
        #region Variables

        public string Account { get; set; }
        public string CostCenter { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Debit { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public bool? Removed { get; set; }
        public string TransactionInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherRow()
        {
            // Set values for instance variables
            this.Account = null;
            this.CostCenter = null;
            this.Credit = null;
            this.Debit = null;
            this.Description = null;
            this.Project = null;
            this.Removed = null;
            this.TransactionInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace