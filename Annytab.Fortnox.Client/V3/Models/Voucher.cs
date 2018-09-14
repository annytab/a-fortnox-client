using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for vouchers
    /// </summary>
    public class VouchersRoot
    {
        #region Variables

        public IList<Voucher> Vouchers { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VouchersRoot()
        {
            this.Vouchers = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for voucher
    /// </summary>
    public class VoucherRoot
    {
        #region Variables

        public Voucher Voucher { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public VoucherRoot()
        {
            this.Voucher = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a voucher
    /// </summary>
    public class Voucher
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Comments { get; set; }
        public string CostCenter { get; set; }
        public string Description { get; set; }
        public string Project { get; set; }
        public string ReferenceNumber { get; set; }
        public string ReferenceType { get; set; }
        public string TransactionDate { get; set; }
        public string VoucherNumber { get; set; }
        public IList<VoucherRow> VoucherRows { get; set; }
        public string VoucherSeries { get; set; }
        public string Year { get; set; }
        public string ApprovalState { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Voucher()
        {
            // Set values for instance variables
            this.Url = null;
            this.Comments = null;
            this.CostCenter = null;
            this.Description = null;
            this.Project = null;
            this.ReferenceNumber = null;
            this.ReferenceType = null;
            this.TransactionDate = null;
            this.VoucherNumber = null;
            this.VoucherRows = null;
            this.VoucherSeries = null;
            this.Year = null;
            this.ApprovalState = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace