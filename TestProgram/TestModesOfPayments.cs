using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestModesOfPayments
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestModesOfPayments()
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
            ModeOfPaymentRoot post = new ModeOfPaymentRoot
            {
                ModeOfPayment = new ModeOfPayment
                {
                    Code = "LB",
                    Description = "Bankgiro LB",
                    AccountNumber = "1940"
                }
            };

            // Add the post
            FortnoxResponse<ModeOfPaymentRoot> fr = await config.fortnox_client.Add<ModeOfPaymentRoot>(post, "modesofpayments");

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
            ModeOfPaymentRoot post = new ModeOfPaymentRoot
            {
                ModeOfPayment = new ModeOfPayment
                {
                    Code = "LB",
                    Description = "Bankgiro LB",
                    AccountNumber = "1930"
                }
            };

            // Update the post
            FortnoxResponse<ModeOfPaymentRoot> fr = await config.fortnox_client.Update<ModeOfPaymentRoot>(post, "modesofpayments/LB");

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
            FortnoxResponse<ModeOfPaymentRoot> fr = await config.fortnox_client.Get<ModeOfPaymentRoot>("modesofpayments/LB");

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
            FortnoxResponse<ModesOfPaymentsRoot> fr = await config.fortnox_client.Get<ModesOfPaymentsRoot>("modesofpayments?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace