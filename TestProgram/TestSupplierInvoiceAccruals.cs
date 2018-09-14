using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestSupplierInvoiceAccruals
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestSupplierInvoiceAccruals()
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
            SupplierInvoiceAccrualRoot post = new SupplierInvoiceAccrualRoot
            {
                SupplierInvoiceAccrual = new SupplierInvoiceAccrual
                {
                    AccrualAccount = "1790",
                    CostAccount = "5820",
                    SupplierInvoiceNumber = "9",
                    Description = "TESTAR",
                    Period = "MONTHLY",
                    StartDate = "2017-04-01",
                    EndDate = "2018-01-31",
                    Total = 40000M,
                    SupplierInvoiceAccrualRows = new List<AccrualRow>
                    {
                       new AccrualRow
                       {
                           Account = "1790",
                           Credit = 4000M,
                           Debit = 0
                       },
                       new AccrualRow
                       {
                           Account = "5820",
                           Credit = 0,
                           Debit = 4000M
                       }
                    }
                }
            };

            // Add the post
            FortnoxResponse<SupplierInvoiceAccrualRoot> fr = await config.fortnox_client.Add<SupplierInvoiceAccrualRoot>(post, "supplierinvoiceaccruals");

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
            SupplierInvoiceAccrualRoot post = new SupplierInvoiceAccrualRoot
            {
                SupplierInvoiceAccrual = new SupplierInvoiceAccrual
                {
                    AccrualAccount = "1790",
                    CostAccount = "5611",
                    SupplierInvoiceNumber = "9",
                    Description = "TESTAR",
                    Period = "MONTHLY",
                    StartDate = "2017-04-01",
                    EndDate = "2018-01-31",
                    Total = 40000M,
                    SupplierInvoiceAccrualRows = new List<AccrualRow>
                    {
                       new AccrualRow
                       {
                           Account = "1790",
                           Credit = 4000M,
                           Debit = 0
                       },
                       new AccrualRow
                       {
                           Account = "5611",
                           Credit = 0,
                           Debit = 4000M
                       }
                    }
                }
            };

            // Update the post
            FortnoxResponse<SupplierInvoiceAccrualRoot> fr = await config.fortnox_client.Update<SupplierInvoiceAccrualRoot>(post, "supplierinvoiceaccruals/9");

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
            FortnoxResponse<SupplierInvoiceAccrualRoot> fr = await config.fortnox_client.Get<SupplierInvoiceAccrualRoot>("supplierinvoiceaccruals/9");

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
            FortnoxResponse<SupplierInvoiceAccrualsRoot> fr = await config.fortnox_client.Get<SupplierInvoiceAccrualsRoot>("supplierinvoiceaccruals?limit=2&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("supplierinvoiceaccruals/9");

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