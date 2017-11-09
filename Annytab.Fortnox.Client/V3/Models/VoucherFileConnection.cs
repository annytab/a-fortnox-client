using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for voucher file connections
    /// </summary>
    public class VoucherFileConnectionsRoot
    {
        #region Variables

        public IList<VoucherFileConnection> VoucherFileConnections { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherFileConnectionsRoot()
        {
            this.VoucherFileConnections = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for voucher file connection
    /// </summary>
    public class VoucherFileConnectionRoot
    {
        #region Variables

        public VoucherFileConnection VoucherFileConnection { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherFileConnectionRoot()
        {
            this.VoucherFileConnection = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an voucher file connection
    /// </summary>
    public class VoucherFileConnection
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string FileId { get; set; }
        public string VoucherDescription { get; set; }
        public string VoucherNumber { get; set; }
        public string VoucherSeries { get; set; }
        public string VoucherYear { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherFileConnection()
        {
            // Set values for instance variables
            this.Url = null;
            this.FileId = null;
            this.VoucherDescription = null;
            this.VoucherNumber = null;
            this.VoucherSeries = null;
            this.VoucherYear = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace