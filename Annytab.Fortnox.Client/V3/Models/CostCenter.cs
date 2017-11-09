using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for cost centers
    /// </summary>
    public class CostCentersRoot
    {
        #region Variables

        public IList<CostCenter> CostCenters { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CostCentersRoot()
        {
            this.CostCenters = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for cost center
    /// </summary>
    public class CostCenterRoot
    {
        #region Variables

        public CostCenter CostCenter { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CostCenterRoot()
        {
            this.CostCenter = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a cost center
    /// </summary>
    public class CostCenter
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public bool? Active { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public CostCenter()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;
            this.Note = null;
            this.Active = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace