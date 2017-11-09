using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for units
    /// </summary>
    public class LabelsRoot
    {
        #region Variables

        public IList<Label> Labels { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public LabelsRoot()
        {
            this.Labels = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for unit
    /// </summary>
    public class LabelRoot
    {
        #region Variables

        public Label Label { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public LabelRoot()
        {
            this.Label = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represent a label
    /// </summary>
    public class Label
    {
        #region Variables

        public string Id { get; set; }
        public string Description { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Label()
        {
            // Set values for instance variables
            this.Id = null;
            this.Description = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace