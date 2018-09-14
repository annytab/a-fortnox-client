using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    Date = "2018-09-10",
                    Hours = 4.45M
                }
            };

            // Add the post
            FortnoxResponse<AttendanceTransactionRoot> fr = await config.fortnox_client.Add<AttendanceTransactionRoot>(post, "attendancetransactions");

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
            AttendanceTransactionRoot post = new AttendanceTransactionRoot
            {
                AttendanceTransaction = new AttendanceTransaction
                {
                    EmployeeId = "1",
                    CauseCode = "TID",
                    Date = "2018-09-10",
                    Hours = 5.72M
                }
            };

            // Update the post
            FortnoxResponse<AttendanceTransactionRoot> fr = await config.fortnox_client.Update<AttendanceTransactionRoot>(post, "attendancetransactions/1/2018-09-10/TID");

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
            FortnoxResponse<AttendanceTransactionRoot> fr = await config.fortnox_client.Get<AttendanceTransactionRoot>("attendancetransactions/1/2018-09-10/TID");

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
            FortnoxResponse<AttendanceTransactionsRoot> fr = await config.fortnox_client.Get<AttendanceTransactionsRoot>("attendancetransactions?limit=2&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("attendancetransactions/1/2018-09-10/TID");

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