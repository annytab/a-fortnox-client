namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for schedule time
    /// </summary>
    public class ScheduleTimeRoot
    {
        #region Variables

        public ScheduleTime ScheduleTime { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ScheduleTimeRoot()
        {
            this.ScheduleTime = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a schedule time
    /// </summary>
    public class ScheduleTime
    {
        #region Variables

        public string EmployeeId { get; set; }
        public string Date { get; set; }
        public string ScheduleId { get; set; }
        public decimal? Hours { get; set; }
        public decimal? IWH1 { get; set; }
        public decimal? IWH2 { get; set; }
        public decimal? IWH3 { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public ScheduleTime()
        {
            // Set values for instance variables
            this.EmployeeId = null;
            this.Date = null;
            this.ScheduleId = null;
            this.Hours = null;
            this.IWH1 = null;
            this.IWH2 = null;
            this.IWH3 = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace