using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestInvoicePayments
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestInvoicePayments()
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
            InvoicePaymentRoot post = new InvoicePaymentRoot
            {
                InvoicePayment = new InvoicePayment
                {
                    Amount = 75M,
                    AmountCurrency = 75M,
                    InvoiceNumber = "1"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<InvoicePaymentRoot>(config.client, post, "invoicepayments");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            InvoicePaymentRoot post = new InvoicePaymentRoot
            {
                InvoicePayment = new InvoicePayment
                {
                    Amount = 70M,
                    AmountCurrency = 100M,
                    InvoiceNumber = "1",
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
            post = await config.fortnox_repository.Update<InvoicePaymentRoot>(config.client, post, "invoicepayments/1/bookkeep");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            InvoicePaymentRoot post = await config.fortnox_repository.Get<InvoicePaymentRoot>(config.client, "invoicepayments/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.InvoicePayment);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            InvoicePaymentsRoot post = await config.fortnox_repository.Get<InvoicePaymentsRoot>(config.client, "invoicepayments?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.InvoicePayments.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "invoicepayments/2");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace