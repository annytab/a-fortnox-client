namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for locked period
    /// </summary>
    public class LockedPeriodRoot
    {
        #region Variables

        public LockedPeriod LockedPeriod { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public LockedPeriodRoot()
        {
            this.LockedPeriod = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a locked period
    /// </summary>
    public class LockedPeriod
    {
        #region Variables

        public string EndDate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public LockedPeriod()
        {
            // Set values for instance variables
            this.EndDate = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace