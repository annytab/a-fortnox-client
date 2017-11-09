using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for account charts
    /// </summary>
    public class AccountChartsRoot
    {
        #region Variables

        public IList<AccountChart> AccountCharts { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AccountChartsRoot()
        {
            this.AccountCharts = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for account chart
    /// </summary>
    public class AccountChartRoot
    {
        #region Variables

        public AccountChart AccountChart { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AccountChartRoot()
        {
            this.AccountChart = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an account chart
    /// </summary>
    public class AccountChart
    {
        #region Variables

        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public AccountChart()
        {
            // Set values for instance variables
            this.Name = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace