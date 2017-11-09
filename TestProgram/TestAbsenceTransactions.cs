using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                    Date = "2017-11-02",
                    Extent = 80.00M

                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<AbsenceTransactionRoot>(config.client, post, "absencetransactions");

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
            post = await config.fortnox_repository.Update<AbsenceTransactionRoot>(config.client, post, "absencetransactions/1/2017-11-02/SJK");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            AbsenceTransactionRoot post = await config.fortnox_repository.Get<AbsenceTransactionRoot>(config.client, "absencetransactions/1/2017-11-02/SJK");

            // Test evaluation
            Assert.AreNotEqual(null, post.AbsenceTransaction);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            AbsenceTransactionsRoot post = await config.fortnox_repository.Get<AbsenceTransactionsRoot>(config.client, "absencetransactions?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.AbsenceTransactions.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "absencetransactions/1/2017-11-02/SJK");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace