namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents an supplier invoice row
    /// </summary>
    public class SupplierInvoiceRow
    {
        #region Variables

        public string Account { get; set; }
        public string ArticleNumber { get; set; }
        public string Code { get; set; }
        public string CostCenter { get; set; }
        public string AccountDescription { get; set; }
        public string ItemDescription { get; set; }
        public decimal? Debit { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? Credit { get; set; }
        public decimal? CreditCurrency { get; set; }
        public string Project { get; set; }
        public string TransactionInformation { get; set; }
        public decimal? Price { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Total { get; set; }
        public string Unit { get; set; }
        public string StockPointCode { get; set; }
        public string StockLocationCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceRow()
        {
            // Set values for instance variables
            this.Account = null;
            this.ArticleNumber = null;
            this.Code = null;
            this.CostCenter = null;
            this.AccountDescription = null;
            this.ItemDescription = null;
            this.Debit = null;
            this.DebitCurrency = null;
            this.Credit = null;
            this.CreditCurrency = null;
            this.Project = null;
            this.TransactionInformation = null;
            this.Price = null;
            this.Quantity = null;
            this.Total = null;
            this.Unit = null;
            this.StockPointCode = null;
            this.StockLocationCode = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace