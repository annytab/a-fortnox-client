using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestAccountCharts
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestAccountCharts()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            AccountChartsRoot post = await config.fortnox_repository.Get<AccountChartsRoot>(config.client, "accountcharts?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.AccountCharts.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace