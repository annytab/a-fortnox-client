using System;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This class represents meta information
    /// </summary>
    public class MetaInformation
    {
        #region Variables

        [JsonProperty("@CurrentPage")]
        public Int32? CurrentPage { get; set; }
        [JsonProperty("@TotalPages")]
        public Int32? TotalPages { get; set; }
        [JsonProperty("@TotalResources")]
        public Int32? TotalResources { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public MetaInformation()
        {
            // Set values for instance variables
            this.CurrentPage = 0;
            this.TotalPages = 0;
            this.TotalResources = 0;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace