using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestAbsenceTransactions
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestAbsenceTransactions()
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
            AbsenceTransactionRoot post = new AbsenceTransactionRoot
            {
                AbsenceTransaction = new AbsenceTransaction
                {
                    EmployeeId = "1",
                    CauseCode = "SJK",
                    Date = "2018-09-08",
                    Extent = 65.00M
                }
            };

            // Add the post
            FortnoxResponse<AbsenceTransactionRoot> fr = await config.fortnox_client.Add<AbsenceTransactionRoot>(post, "absencetransactions");

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
            AbsenceTransactionRoot post = new AbsenceTransactionRoot
            {
                AbsenceTransaction = new AbsenceTransaction
                {
                    Hours = 6M
                }
            };

            // Update the post
            FortnoxResponse<AbsenceTransactionRoot> fr = await config.fortnox_client.Update<AbsenceTransactionRoot>(post, "absencetransactions/1/2018-09-10/SJK");

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
            FortnoxResponse<AbsenceTransactionRoot> fr = await config.fortnox_client.Get<AbsenceTransactionRoot>("absencetransactions/1/2018-09-08/SJK");

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
            FortnoxResponse<AbsenceTransactionsRoot> fr = await config.fortnox_client.Get<AbsenceTransactionsRoot>("absencetransactions?limit=2&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("absencetransactions/1/2017-11-02/SJK");

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