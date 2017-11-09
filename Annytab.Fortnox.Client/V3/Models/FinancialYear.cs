using System.Collections.Generic;
using Newtonsoft.Json;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for financial years
    /// </summary>
    public class FinancialYearsRoot
    {
        #region Variables

        public IList<FinancialYear> FinancialYears { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FinancialYearsRoot()
        {
            this.FinancialYears = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for financial year
    /// </summary>
    public class FinancialYearRoot
    {
        #region Variables

        public FinancialYear FinancialYear { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FinancialYearRoot()
        {
            this.FinancialYear = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents a financial year
    /// </summary>
    public class FinancialYear
    {
        #region Variables

        [JsonProperty("@url")]
        public string Url { get; set; }
        public string Id { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string AccountChartType { get; set; }
        public string AccountingMethod { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public FinancialYear()
        {
            // Set values for instance variables
            this.Url = null;
            this.Id = null;
            this.FromDate = null;
            this.ToDate = null;
            this.AccountChartType = null;
            this.AccountingMethod = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace