using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for terms of payments
    /// </summary>
    public class TermsOfPaymentsRoot
    {
        #region Variables

        public IList<TermsOfPayment> TermsOfPayments { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TermsOfPaymentsRoot()
        {
            this.TermsOfPayments = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for terms of payment
    /// </summary>
    public class TermsOfPaymentRoot
    {
        #region Variables

        public TermsOfPayment TermsOfPayment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TermsOfPaymentRoot()
        {
            this.TermsOfPayment = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a term of payment
    /// </summary>
    public class TermsOfPayment
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TermsOfPayment()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace