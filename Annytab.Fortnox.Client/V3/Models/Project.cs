using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for projects
    /// </summary>
    public class ProjectsRoot
    {
        #region Variables

        public IList<Project> Projects { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ProjectsRoot()
        {
            this.Projects = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for project
    /// </summary>
    public class ProjectRoot
    {
        #region Variables

        public Project Project { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ProjectRoot()
        {
            this.Project = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a project
    /// </summary>
    public class Project
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Comments { get; set; }
        public string ContactPerson { get; set; }
        public string Description { get; set; }
        public string EndDate { get; set; }
        public string ProjectLeader { get; set; }
        public string ProjectNumber { get; set; }
        public string Status { get; set; }
        public string StartDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Project()
        {
            // Set values for instance variables
            this.Url = null;
            this.Comments = null;
            this.ContactPerson = null;
            this.Description = null;
            this.EndDate = null;
            this.ProjectLeader = null;
            this.ProjectNumber = null;
            this.Status = null;
            this.StartDate = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace