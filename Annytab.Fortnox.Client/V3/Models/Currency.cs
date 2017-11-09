using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for currencies
    /// </summary>
    public class CurrenciesRoot
    {
        #region Variables

        public IList<Currency> Currencies { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CurrenciesRoot()
        {
            this.Currencies = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for currency
    /// </summary>
    public class CurrencyRoot
    {
        #region Variables

        public Currency Currency { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CurrencyRoot()
        {
            this.Currency = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a currency
    /// </summary>
    public class Currency
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public decimal? BuyRate { get; set; }
        public string Code { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public decimal? SellRate { get; set; }
        public decimal? Unit { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Currency()
        {
            // Set values for instance variables
            this.Url = null;
            this.BuyRate = null;
            this.Code = null;
            this.Date = null;
            this.Description = null;
            this.SellRate = null;
            this.Unit = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace