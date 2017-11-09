using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for price lists
    /// </summary>
    public class PriceListsRoot
    {
        #region Variables

        public IList<PriceList> PriceLists { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PriceListsRoot()
        {
            this.PriceLists = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for price list
    /// </summary>
    public class PriceListRoot
    {
        #region Variables

        public PriceList PriceList { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PriceListRoot()
        {
            this.PriceList = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a price list
    /// </summary>
    public class PriceList
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comments { get; set; }
        public bool? PreSelected { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PriceList()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;
            this.Comments = null;
            this.PreSelected = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace