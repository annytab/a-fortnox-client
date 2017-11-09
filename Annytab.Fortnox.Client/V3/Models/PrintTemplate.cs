using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for print templates
    /// </summary>
    public class PrintTemplatesRoot
    {
        #region Variables

        public IList<PrintTemplate> PrintTemplates { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PrintTemplatesRoot()
        {
            this.PrintTemplates = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for print template
    /// </summary>
    public class PrintTemplateRoot
    {
        #region Variables

        public PrintTemplate PrintTemplate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PrintTemplateRoot()
        {
            this.PrintTemplate = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a print template
    /// </summary>
    public class PrintTemplate
    {
        #region Variables

        public string Template { get; set; }
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public PrintTemplate()
        {
            // Set values for instance variables
            this.Template = null;
            this.Name = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace