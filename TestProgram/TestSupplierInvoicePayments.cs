using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
            FortnoxResponse<SupplierInvoicePaymentRoot> fr = await config.fortnox_client.Add<SupplierInvoicePaymentRoot>(post, "supplierinvoicepayments");

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
            FortnoxResponse<SupplierInvoicePaymentRoot> fr = await config.fortnox_client.Update<SupplierInvoicePaymentRoot>(post, "supplierinvoicepayments/4");

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
            FortnoxResponse<SupplierInvoicePaymentRoot> fr = await config.fortnox_client.Get<SupplierInvoicePaymentRoot>("supplierinvoicepayments/4");

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
            FortnoxResponse<SupplierInvoicePaymentsRoot> fr = await config.fortnox_client.Get<SupplierInvoicePaymentsRoot>("supplierinvoicepayments?limit=10&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("supplierinvoicepayments/1");

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