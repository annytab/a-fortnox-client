namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents an asset history row
    /// </summary>
    public class AssetHistoryRow
    {
        #region Variables

        public string Id { get; set; }
        public string Date { get; set; }
        public string EventId { get; set; }
        public decimal? Amount { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Notes { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }
        public string SupplierInvoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetHistoryRow()
        {
            // Set values for instance variables
            this.Id = null;
            this.Date = null;
            this.EventId = null;
            this.Amount = null;
            this.UserId = null;
            this.UserName = null;
            this.Notes = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;
            this.SupplierInvoice = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace