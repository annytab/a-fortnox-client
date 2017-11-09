using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for prices
    /// </summary>
    public class PricesRoot
    {
        #region Variables

        public IList<Price> Prices { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PricesRoot()
        {
            this.Prices = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for prices
    /// </summary>
    public class PriceRoot
    {
        #region Variables

        public Price Price { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PriceRoot()
        {
            this.Price = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a price
    /// </summary>
    public class Price
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string ArticleNumber { get; set; }
        public string Date { get; set; }
        public decimal? FromQuantity { get; set; }
        public decimal? Percent { get; set; }
        [JsonProperty("Price")]
        public decimal? Amount { get; set; }
        public string PriceList { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Price()
        {
            // Set values for instance variables
            this.Url = null;
            this.ArticleNumber = null;
            this.Date = null;
            this.FromQuantity = null;
            this.Percent = null;
            this.Amount = null;
            this.PriceList = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace