using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for file
    /// </summary>
    public class FileRoot
    {
        #region Variables

        public File File { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FileRoot()
        {
            this.File = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a file
    /// </summary>
    public class File
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Comments { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Size { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public File()
        {
            // Set values for instance variables
            this.Url = null;
            this.Comments = null;
            this.Id = null;
            this.Name = null;
            this.Path = null;
            this.Size = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace