using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for Predefined Voucher Series
    /// </summary>
    public class PreDefinedVoucherSeriesCollectionRoot
    {
        #region Variables

        public IList<PreDefinedVoucherSeries> PreDefinedVoucherSeriesCollection { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PreDefinedVoucherSeriesCollectionRoot()
        {
            this.PreDefinedVoucherSeriesCollection = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for unit
    /// </summary>
    public class PreDefinedVoucherSeriesRoot
    {
        #region Variables

        public PreDefinedVoucherSeries PreDefinedVoucherSeries { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PreDefinedVoucherSeriesRoot()
        {
            this.PreDefinedVoucherSeries = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a unit
    /// </summary>
    public class PreDefinedVoucherSeries
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Name { get; set; }
        public string VoucherSeries { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PreDefinedVoucherSeries()
        {
            // Set values for instance variables
            this.Url = null;
            this.Name = null;
            this.VoucherSeries = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace