using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for salary transactions
    /// </summary>
    public class SalaryTransactionsRoot
    {
        #region Variables

        public IList<SalaryTransaction> SalaryTransactions { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SalaryTransactionsRoot()
        {
            this.SalaryTransactions = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for salary transaction
    /// </summary>
    public class SalaryTransactionRoot
    {
        #region Variables

        public SalaryTransaction SalaryTransaction { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SalaryTransactionRoot()
        {
            this.SalaryTransaction = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a salary transaction
    /// </summary>
    public class SalaryTransaction
    {
        #region Variables

        public string EmployeeId { get; set; }
        public string SalaryCode { get; set; }
        public string SalaryRow { get; set; }
        public string Date { get; set; }
        public decimal? Number { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Total { get; set; }
        public string Expense { get; set; }
        public decimal? VAT { get; set; }
        public string TextRow { get; set; }
        public string CostCenter { get; set; }
        public string Project { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public SalaryTransaction()
        {
            // Set values for instance variables
            this.EmployeeId = null;
            this.SalaryCode = null;
            this.SalaryRow = null;
            this.Date = null;
            this.Number = null;
            this.Amount = null;
            this.Total = null;
            this.Expense = null;
            this.VAT = null;
            this.TextRow = null;
            this.CostCenter = null;
            this.Project = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace