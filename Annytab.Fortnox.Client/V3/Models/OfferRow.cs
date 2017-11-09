using System;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents an offer row
    /// </summary>
    public class OfferRow
    {
        #region Variables

        public string AccountNumber { get; set; }
        public string ArticleNumber { get; set; }
        public decimal? ContributionPercent { get; set; }
        public decimal? ContributionValue { get; set; }
        public string CostCenter { get; set; }
        public string Description { get; set; }
        public decimal? Discount { get; set; }
        public string DiscountType { get; set; }
        public bool? HouseWork { get; set; }
        public Int32? HouseWorkHoursToReport { get; set; }
        public string HouseWorkType { get; set; }
        public decimal? Price { get; set; }
        public string Project { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Total { get; set; }
        public string Unit { get; set; }
        public decimal? VAT { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public OfferRow()
        {
            // Set values for instance variables
            this.AccountNumber = null;
            this.ArticleNumber = null;
            this.ContributionPercent = null;
            this.ContributionValue = null;
            this.CostCenter = null;
            this.Description = null;
            this.Discount = null;
            this.DiscountType = null;
            this.HouseWork = null;
            this.HouseWorkHoursToReport = null;
            this.HouseWorkType = null;
            this.Price = null;
            this.Project = null;
            this.Quantity = null;
            this.Total = null;
            this.Unit = null;
            this.VAT = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace