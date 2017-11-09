using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for way of deliveries
    /// </summary>
    public class WayOfDeliveriesRoot
    {
        #region Variables

        public IList<WayOfDelivery> WayOfDeliveries { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public WayOfDeliveriesRoot()
        {
            this.WayOfDeliveries = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for way of delivery
    /// </summary>
    public class WayOfDeliveryRoot
    {
        #region Variables

        public WayOfDelivery WayOfDelivery { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public WayOfDeliveryRoot()
        {
            this.WayOfDelivery = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a way of delivery
    /// </summary>
    public class WayOfDelivery
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
        public WayOfDelivery()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace