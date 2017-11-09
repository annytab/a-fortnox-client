using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for voucher series
    /// </summary>
    public class VoucherSeriesCollectionRoot
    {
        #region Variables

        public IList<VoucherSeries> VoucherSeriesCollection { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherSeriesCollectionRoot()
        {
            this.VoucherSeriesCollection = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for voucher series
    /// </summary>
    public class VoucherSeriesRoot
    {
        #region Variables

        public VoucherSeries VoucherSeries { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherSeriesRoot()
        {
            this.VoucherSeries = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a voucher series
    /// </summary>
    public class VoucherSeries
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Manual { get; set; }
        public string NextVoucherNumber { get; set; }
        public string Year { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherSeries()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;
            this.Manual = null;
            this.NextVoucherNumber = null;
            this.Year = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace