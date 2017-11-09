using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestInvoiceAccruals
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestInvoiceAccruals()
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
            InvoiceAccrualRoot post = new InvoiceAccrualRoot
            {
                InvoiceAccrual = new InvoiceAccrual
                {
                    AccrualAccount = "2990",
                    RevenueAccount = "3990",
                    InvoiceNumber = "25",
                    Description = "TESTAR",
                    Period = "MONTHLY",
                    StartDate = "2017-04-01",
                    EndDate = "2018-01-31",
                    Total = 50000M,
                    InvoiceAccrualRows = new List<AccrualRow>
                    {
                       new AccrualRow
                       {
                           Account = "2990",
                           Credit = 0M,
                           Debit = 5000M
                       },
                       new AccrualRow
                       {
                           Account = "3990",
                           Credit = 5000M,
                           Debit = 0
                       }
                    }
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<InvoiceAccrualRoot>(config.client, post, "invoiceaccruals");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            InvoiceAccrualRoot post = new InvoiceAccrualRoot
            {
                InvoiceAccrual = new InvoiceAccrual
                {
                    AccrualAccount = "2990",
                    RevenueAccount = "3600",
                    Period = "MONTHLY",
                    StartDate = "2017-04-01",
                    EndDate = "2018-01-31",
                    Total = 50000M,
                    InvoiceAccrualRows = new List<AccrualRow>
                    {
                       new AccrualRow
                       {
                           Account = "2990",
                           Credit = 0M,
                           Debit = 5000M
                       },
                       new AccrualRow
                       {
                           Account = "3600",
                           Credit = 5000M,
                           Debit = 0
                       }
                    }
                }
            };
            // Update the post
            post = await config.fortnox_repository.Update<InvoiceAccrualRoot>(config.client, post, "invoiceaccruals/25");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            InvoiceAccrualRoot post = await config.fortnox_repository.Get<InvoiceAccrualRoot>(config.client, "invoiceaccruals/25");

            // Test evaluation
            Assert.AreNotEqual(null, post.InvoiceAccrual);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            InvoiceAccrualsRoot post = await config.fortnox_repository.Get<InvoiceAccrualsRoot>(config.client, "invoiceaccruals?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.InvoiceAccruals.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "invoiceaccruals/25");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace