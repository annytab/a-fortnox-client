using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestTermsOfPayments
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestTermsOfPayments()
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
            TermsOfPaymentRoot post = new TermsOfPaymentRoot
            {
                TermsOfPayment = new TermsOfPayment
                {
                    Code = "PAYPAL",
                    Description = "Paypal inc"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<TermsOfPaymentRoot>(config.client, post, "termsofpayments");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            TermsOfPaymentRoot post = new TermsOfPaymentRoot
            {
                TermsOfPayment = new TermsOfPayment
                {
                    Code = "PAYPAL",
                    Description = "Pay with PP"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<TermsOfPaymentRoot>(config.client, post, "termsofpayments/PAYPAL");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            TermsOfPaymentRoot post = await config.fortnox_repository.Get<TermsOfPaymentRoot>(config.client, "termsofpayments/PAYPAL");

            // Test evaluation
            Assert.AreNotEqual(null, post.TermsOfPayment);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            TermsOfPaymentsRoot post = await config.fortnox_repository.Get<TermsOfPaymentsRoot>(config.client, "termsofpayments?limit=5&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.TermsOfPayments.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "termsofpayments/PAYPAL");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace