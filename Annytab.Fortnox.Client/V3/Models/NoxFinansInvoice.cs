using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for nox finans invoice
    /// </summary>
    public class NoxFinansInvoiceRoot
    {
        #region Variables

        public NoxFinansInvoice NoxFinansInvoice { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public NoxFinansInvoiceRoot()
        {
            this.NoxFinansInvoice = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a nox finans invoice
    /// </summary>
    public class NoxFinansInvoice
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public decimal? BalanceIncludeFees { get; set; }
        public decimal? BalanceIncludeFeesCurrency { get; set; }
        public decimal? CurrentCapitalBalance { get; set; }
        public decimal? CurrentCapitalBalanceCurrency { get; set; }
        public string InvoiceDocumentURL { get; set; }
        public string InvoiceNumber { get; set; }
        public string NextEvent { get; set; }
        public string NextEventDate { get; set; }
        public string OCRNumber { get; set; }
        public string Service { get; set; }
        public string SendMethod { get; set; }
        public string Status { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public NoxFinansInvoice()
        {
            // Set values for instance variables
            this.Url = null;
            this.BalanceIncludeFees = null;
            this.BalanceIncludeFeesCurrency = null;
            this.CurrentCapitalBalance = null;
            this.CurrentCapitalBalanceCurrency = null;
            this.InvoiceDocumentURL = null;
            this.InvoiceNumber = null;
            this.NextEvent = null;
            this.NextEventDate = null;
            this.OCRNumber = null;
            this.Service = null;
            this.SendMethod = null;
            this.Status = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace