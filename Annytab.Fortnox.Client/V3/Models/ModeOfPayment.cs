using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for modes of payments
    /// </summary>
    public class ModesOfPaymentsRoot
    {
        #region Variables

        public IList<ModeOfPayment> ModesOfPayments { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ModesOfPaymentsRoot()
        {
            this.ModesOfPayments = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for mode of payment
    /// </summary>
    public class ModeOfPaymentRoot
    {
        #region Variables

        public ModeOfPayment ModeOfPayment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ModeOfPaymentRoot()
        {
            this.ModeOfPayment = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a mode of payment
    /// </summary>
    public class ModeOfPayment
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ModeOfPayment()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;
            this.AccountNumber = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace