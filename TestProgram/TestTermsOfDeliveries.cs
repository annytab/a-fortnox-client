using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<TermsOfDeliveryRoot>(config.client, post, "termsofdeliveries");

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
            post = await config.fortnox_repository.Update<TermsOfDeliveryRoot>(config.client, post, "termsofdeliveries/WEB");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            TermsOfDeliveryRoot post = await config.fortnox_repository.Get<TermsOfDeliveryRoot>(config.client, "termsofdeliveries/WEB");

            // Test evaluation
            Assert.AreNotEqual(null, post.TermsOfDelivery);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            TermsOfDeliveriesRoot post = await config.fortnox_repository.Get<TermsOfDeliveriesRoot>(config.client, "termsofdeliveries");

            // Test evaluation
            Assert.AreNotEqual(0, post.TermsOfDeliveries.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace