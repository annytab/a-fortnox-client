using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestSalaryTransactions
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestSalaryTransactions()
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
            SalaryTransactionRoot post = new SalaryTransactionRoot
            {
                SalaryTransaction = new SalaryTransaction
                {
                    EmployeeId = "1",
                    SalaryCode = "1321",
                    Date = "2016-01-06",
                    Number = 5,
                    Amount = 10000M,
                    CostCenter = "TT2",
                    Project = "A2"
                }
            };

            // Add the post
            FortnoxResponse<SalaryTransactionRoot> fr = await config.fortnox_client.Add<SalaryTransactionRoot>(post, "salarytransactions");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            SalaryTransactionRoot post = new SalaryTransactionRoot
            {
                SalaryTransaction = new SalaryTransaction
                {
                    Number = 15,
                    Amount = 20000M
                }
            };

            // Update the post
            FortnoxResponse<SalaryTransactionRoot> fr = await config.fortnox_client.Update<SalaryTransactionRoot>(post, "salarytransactions/3");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<SalaryTransactionRoot> fr = await config.fortnox_client.Get<SalaryTransactionRoot>("salarytransactions/5");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FortnoxResponse<SalaryTransactionsRoot> fr = await config.fortnox_client.Get<SalaryTransactionsRoot>("salarytransactions?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("salarytransactions/1");

            // Log the error
            if (fr.model == false)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreEqual(true, fr.model);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace