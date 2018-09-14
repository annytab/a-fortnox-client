using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestTermsOfDeliveries
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestTermsOfDeliveries()
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
            TermsOfDeliveryRoot post = new TermsOfDeliveryRoot
            {
                TermsOfDelivery = new TermsOfDelivery
                {
                    Code = "WEB",
                    Description = "Downloaded"
                }
            };

            // Add the post
            FortnoxResponse<TermsOfDeliveryRoot> fr = await config.fortnox_client.Add<TermsOfDeliveryRoot>(post, "termsofdeliveries");

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
            TermsOfDeliveryRoot post = new TermsOfDeliveryRoot
            {
                TermsOfDelivery = new TermsOfDelivery
                {
                    Code = "WEB",
                    Description = "Internet"
                }
            };

            // Update the post
            FortnoxResponse<TermsOfDeliveryRoot> fr = await config.fortnox_client.Update<TermsOfDeliveryRoot>(post, "termsofdeliveries/WEB");

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
            FortnoxResponse<TermsOfDeliveryRoot> fr = await config.fortnox_client.Get<TermsOfDeliveryRoot>("termsofdeliveries/WEB");

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
            FortnoxResponse<TermsOfDeliveriesRoot> fr = await config.fortnox_client.Get<TermsOfDeliveriesRoot>("termsofdeliveries");

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