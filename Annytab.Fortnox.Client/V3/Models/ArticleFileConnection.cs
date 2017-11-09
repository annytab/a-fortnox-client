using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for article file connections
    /// </summary>
    public class ArticleFileConnectionsRoot
    {
        #region Variables

        public IList<ArticleFileConnection> ArticleFileConnections { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ArticleFileConnectionsRoot()
        {
            this.ArticleFileConnections = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for article file connection
    /// </summary>
    public class ArticleFileConnectionRoot
    {
        #region Variables

        public ArticleFileConnection ArticleFileConnection { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ArticleFileConnectionRoot()
        {
            this.ArticleFileConnection = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an article file connection
    /// </summary>
    public class ArticleFileConnection
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string FileId { get; set; }
        public string ArticleNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ArticleFileConnection()
        {
            // Set values for instance variables
            this.Url = null;
            this.FileId = null;
            this.ArticleNumber = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace