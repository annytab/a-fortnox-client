using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for supplier invoice file connections
    /// </summary>
    public class SupplierInvoiceFileConnectionsRoot
    {
        #region Variables

        public IList<SupplierInvoiceFileConnection> SupplierInvoiceFileConnections { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceFileConnectionsRoot()
        {
            this.SupplierInvoiceFileConnections = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for supplier invoice file connection
    /// </summary>
    public class SupplierInvoiceFileConnectionRoot
    {
        #region Variables

        public SupplierInvoiceFileConnection SupplierInvoiceFileConnection { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceFileConnectionRoot()
        {
            this.SupplierInvoiceFileConnection = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an supplier invoice file connection
    /// </summary>
    public class SupplierInvoiceFileConnection
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string FileId { get; set; }
        public string Name { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public string SupplierName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SupplierInvoiceFileConnection()
        {
            // Set values for instance variables
            this.Url = null;
            this.FileId = null;
            this.Name = null;
            this.SupplierInvoiceNumber = null;
            this.SupplierName = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace