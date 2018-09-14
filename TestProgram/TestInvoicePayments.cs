using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    InvoiceNumber = "2"
                }
            };

            // Add the post
            FortnoxResponse<InvoicePaymentRoot> fr = await config.fortnox_client.Add<InvoicePaymentRoot>(post, "invoicepayments");

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
            InvoicePaymentRoot post = new InvoicePaymentRoot
            {
                InvoicePayment = new InvoicePayment
                {
                    Amount = 70M,
                    AmountCurrency = 100M,
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
            FortnoxResponse<InvoicePaymentRoot> fr = await config.fortnox_client.Update<InvoicePaymentRoot>(post, "invoicepayments/5");

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
            FortnoxResponse<InvoicePaymentRoot> fr = await config.fortnox_client.Get<InvoicePaymentRoot>("invoicepayments/5");

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
            FortnoxResponse<InvoicePaymentsRoot> fr = await config.fortnox_client.Get<InvoicePaymentsRoot>("invoicepayments?limit=10&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("invoicepayments/2");

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