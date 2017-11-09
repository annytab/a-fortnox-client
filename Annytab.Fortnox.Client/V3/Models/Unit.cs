using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for units
    /// </summary>
    public class UnitsRoot
    {
        #region Variables

        public IList<Unit> Units { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public UnitsRoot()
        {
            this.Units = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for unit
    /// </summary>
    public class UnitRoot
    {
        #region Variables

        public Unit Unit { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public UnitRoot()
        {
            this.Unit = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a unit
    /// </summary>
    public class Unit
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
        public Unit()
        {
            // Set values for instance variables
            this.Url = null;
            this.Code = null;
            this.Description = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace