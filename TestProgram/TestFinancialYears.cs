using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestFinancialYears
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestFinancialYears()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to add a post
        /// </summary>
        [TestMethod]
        public async Task TestAddPost()
        {
            // Create a post
            FinancialYearRoot post = new FinancialYearRoot
            {
                FinancialYear = new FinancialYear
                {
                    FromDate = "2018-01-01",
                    ToDate = "2018-12-31",
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<FinancialYearRoot>(config.client, post, "financialyears");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FinancialYearRoot post = await config.fortnox_repository.Get<FinancialYearRoot>(config.client, "financialyears/3");

            // Test evaluation
            Assert.AreNotEqual(null, post.FinancialYear);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FinancialYearsRoot post = await config.fortnox_repository.Get<FinancialYearsRoot>(config.client, "financialyears?limit=3&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.FinancialYears.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace