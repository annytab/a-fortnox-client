using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                    Date = "2017-11-05",
                    Number = 5,
                    Amount = 10000M
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<SalaryTransactionRoot>(config.client, post, "salarytransactions");

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
            post = await config.fortnox_repository.Update<SalaryTransactionRoot>(config.client, post, "salarytransactions/1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            SalaryTransactionRoot post = await config.fortnox_repository.Get<SalaryTransactionRoot>(config.client, "salarytransactions/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.SalaryTransaction);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            SalaryTransactionsRoot post = await config.fortnox_repository.Get<SalaryTransactionsRoot>(config.client, "salarytransactions?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.SalaryTransactions.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "salarytransactions/2");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace