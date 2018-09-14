using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for asset file connections
    /// </summary>
    public class AssetFileConnectionsRoot
    {
        #region Variables

        public IList<AssetFileConnection> AssetFileConnections { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetFileConnectionsRoot()
        {
            this.AssetFileConnections = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for asset file connection
    /// </summary>
    public class AssetFileConnectionRoot
    {
        #region Variables

        public AssetFileConnection AssetFileConnection { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetFileConnectionRoot()
        {
            this.AssetFileConnection = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a asset file connection
    /// </summary>
    public class AssetFileConnection
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string FileId { get; set; }
        public string Name { get; set; }
        public string AssetId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AssetFileConnection()
        {
            // Set values for instance variables
            this.Url = null;
            this.FileId = null;
            this.Name = null;
            this.AssetId = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace