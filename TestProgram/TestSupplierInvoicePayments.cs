using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestSupplierInvoicePayments
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestSupplierInvoicePayments()
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
            SupplierInvoicePaymentRoot post = new SupplierInvoicePaymentRoot
            {
                SupplierInvoicePayment = new SupplierInvoicePayment
                {
                    Amount = 110M,
                    AmountCurrency = 110M,
                    InvoiceNumber = "2"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<SupplierInvoicePaymentRoot>(config.client, post, "supplierinvoicepayments");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            SupplierInvoicePaymentRoot post = new SupplierInvoicePaymentRoot
            {
                SupplierInvoicePayment = new SupplierInvoicePayment
                {
                    Amount = 945M,
                    AmountCurrency = 945M,
                    InvoiceNumber = "2",
                    WriteOffs = new List<WriteOff>
                    {
                        new WriteOff
                        {
                            AccountNumber = "6570",
                            Amount = 55M
                        }
                    }
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<SupplierInvoicePaymentRoot>(config.client, post, "supplierinvoicepayments/1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            SupplierInvoicePaymentRoot post = await config.fortnox_repository.Get<SupplierInvoicePaymentRoot>(config.client, "supplierinvoicepayments/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.SupplierInvoicePayment);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            SupplierInvoicePaymentsRoot post = await config.fortnox_repository.Get<SupplierInvoicePaymentsRoot>(config.client, "supplierinvoicepayments?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.SupplierInvoicePayments.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "supplierinvoicepayments/1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace