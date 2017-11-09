using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for attendance transactions
    /// </summary>
    public class AttendanceTransactionsRoot
    {
        #region Variables

        public IList<AttendanceTransaction> AttendanceTransactions { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AttendanceTransactionsRoot()
        {
            this.AttendanceTransactions = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for attendance transaction
    /// </summary>
    public class AttendanceTransactionRoot
    {
        #region Variables

        public AttendanceTransaction AttendanceTransaction { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AttendanceTransactionRoot()
        {
            this.AttendanceTransaction = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an article url connection
    /// </summary>
    public class AttendanceTransaction
    {
        #region Variables

        public string EmployeeId { get; set; }
        public string CauseCode { get; set; }
        public string Date { get; set; }
        public decimal? Hours { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AttendanceTransaction()
        {
            // Set values for instance variables
            this.EmployeeId = null;
            this.CauseCode = null;
            this.Date = null;
            this.Hours = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace