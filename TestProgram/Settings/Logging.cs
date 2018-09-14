namespace TestProgram
{
    /// <summary>
    /// This class represents configuration settings
    /// </summary>
    public class Logging
    {
        #region Variables

        public bool IncludeScopes { get; set; }
        public LogLevel LogLevel { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Logging()
        {
            // Set values for instance variables
            this.IncludeScopes = false;
            this.LogLevel = new LogLevel();

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace