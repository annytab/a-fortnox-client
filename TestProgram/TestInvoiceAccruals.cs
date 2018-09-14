using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    InvoiceNumber = "31",
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
            FortnoxResponse<InvoiceAccrualRoot> fr = await config.fortnox_client.Add<InvoiceAccrualRoot>(post, "invoiceaccruals");

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
            FortnoxResponse<InvoiceAccrualRoot> fr = await config.fortnox_client.Update<InvoiceAccrualRoot>(post, "invoiceaccruals/31");

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
            FortnoxResponse<InvoiceAccrualRoot> fr = await config.fortnox_client.Get<InvoiceAccrualRoot>("invoiceaccruals/31");

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
            FortnoxResponse<InvoiceAccrualsRoot> fr = await config.fortnox_client.Get<InvoiceAccrualsRoot>("invoiceaccruals?limit=2&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("invoiceaccruals/25");

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