using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestAttendanceTransactions
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestAttendanceTransactions()
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
            AttendanceTransactionRoot post = new AttendanceTransactionRoot
            {
                AttendanceTransaction = new AttendanceTransaction
                {
                    EmployeeId = "1",
                    CauseCode = "TID",
                    Date = "2017-11-02",
                    Hours = 4.45M
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<AttendanceTransactionRoot>(config.client, post, "attendancetransactions");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            AttendanceTransactionRoot post = new AttendanceTransactionRoot
            {
                AttendanceTransaction = new AttendanceTransaction
                {
                    EmployeeId = "1",
                    CauseCode = "TID",
                    Date = "2017-11-02",
                    Hours = 5.72M
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<AttendanceTransactionRoot>(config.client, post, "attendancetransactions/1/2017-11-02/TID");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            AttendanceTransactionRoot post = await config.fortnox_repository.Get<AttendanceTransactionRoot>(config.client, "attendancetransactions/1/2017-11-02/TID");

            // Test evaluation
            Assert.AreNotEqual(null, post.AttendanceTransaction);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            AttendanceTransactionsRoot post = await config.fortnox_repository.Get<AttendanceTransactionsRoot>(config.client, "attendancetransactions?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.AttendanceTransactions.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "attendancetransactions/1/2017-11-02/TID");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace