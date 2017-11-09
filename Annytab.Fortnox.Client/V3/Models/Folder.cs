using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for folder
    /// </summary>
    public class FolderRoot
    {
        #region Variables

        public Folder Folder { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FolderRoot()
        {
            this.Folder = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a folder
    /// </summary>
    public class Folder
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Email { get; set; }
        public IList<File> Files { get; set; }
        public IList<Folder> Folders { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Folder()
        {
            // Set values for instance variables
            this.Url = null;
            this.Email = null;
            this.Files = null;
            this.Folders = null;
            this.Id = null;
            this.Name = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace