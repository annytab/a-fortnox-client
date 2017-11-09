using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<SupplierInvoiceAccrualRoot>(config.client, post, "supplierinvoiceaccruals");

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
            post = await config.fortnox_repository.Update<SupplierInvoiceAccrualRoot>(config.client, post, "supplierinvoiceaccruals/9");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            SupplierInvoiceAccrualRoot post = await config.fortnox_repository.Get<SupplierInvoiceAccrualRoot>(config.client, "supplierinvoiceaccruals/9");

            // Test evaluation
            Assert.AreNotEqual(null, post.SupplierInvoiceAccrual);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            SupplierInvoiceAccrualsRoot post = await config.fortnox_repository.Get<SupplierInvoiceAccrualsRoot>(config.client, "supplierinvoiceaccruals?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.SupplierInvoiceAccruals.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "supplierinvoiceaccruals/9");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace