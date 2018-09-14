using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    /// <summary>
    /// This class represent application settings
    /// </summary>
    public class AppSettings
    {
        #region Variables

        public Logging Logging { get; set; }
        public FortnoxOptions FortnoxOptions { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AppSettings()
        {
            // Set values for instance variables
            this.Logging = new Logging();
            this.FortnoxOptions = new FortnoxOptions();

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace