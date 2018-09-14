namespace TestProgram
{
    /// <summary>
    /// This class represents configuration settings
    /// </summary>
    public class LogLevel
    {
        #region Variables

        public string Default { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public LogLevel()
        {
            // Set values for instance variables
            this.Default = "Information";

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace