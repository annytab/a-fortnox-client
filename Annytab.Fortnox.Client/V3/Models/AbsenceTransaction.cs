using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for absence transactions
    /// </summary>
    public class AbsenceTransactionsRoot
    {
        #region Variables

        public IList<AbsenceTransaction> AbsenceTransactions { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AbsenceTransactionsRoot()
        {
            this.AbsenceTransactions = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for absence transaction
    /// </summary>
    public class AbsenceTransactionRoot
    {
        #region Variables

        public AbsenceTransaction AbsenceTransaction { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AbsenceTransactionRoot()
        {
            this.AbsenceTransaction = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an absence transaction
    /// </summary>
    public class AbsenceTransaction
    {
        #region Variables

        public string EmployeeId { get; set; }
        public string CauseCode { get; set; }
        public string Date { get; set; }
        public decimal? Extent { get; set; }
        public decimal? Hours { get; set; }
        public bool? HolidayEntitling { get; set; }
        public string CostCenter { get; set; }
        public string Project { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AbsenceTransaction()
        {
            // Set values for instance variables
            this.EmployeeId = null;
            this.CauseCode = null;
            this.Date = null;
            this.Extent = null;
            this.Hours = null;
            this.HolidayEntitling = null;
            this.CostCenter = null;
            this.Project = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace