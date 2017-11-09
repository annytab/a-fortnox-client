using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for terms of deliveries
    /// </summary>
    public class TermsOfDeliveriesRoot
    {
        #region Variables

        public IList<TermsOfDelivery> TermsOfDeliveries { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TermsOfDeliveriesRoot()
        {
            this.TermsOfDeliveries = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for terms of delivery
    /// </summary>
    public class TermsOfDeliveryRoot
    {
        #region Variables

        public TermsOfDelivery TermsOfDelivery { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public TermsOfDeliveryRoot()
        {
            this.TermsOfDelivery = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a term of delivery
    /// </summary>
    public class TermsOfDelivery
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
        public TermsOfDelivery()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace