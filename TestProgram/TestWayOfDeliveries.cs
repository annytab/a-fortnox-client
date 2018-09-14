using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestWayOfDeliveries
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestWayOfDeliveries()
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
            WayOfDeliveryRoot post = new WayOfDeliveryRoot
            {
                WayOfDelivery = new WayOfDelivery
                {
                    Code = "BÅT",
                    Description = "By boat"
                }
            };

            // Add the post
            FortnoxResponse<WayOfDeliveryRoot> fr = await config.fortnox_client.Add<WayOfDeliveryRoot>(post, "wayofdeliveries");

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
            WayOfDeliveryRoot post = new WayOfDeliveryRoot
            {
                WayOfDelivery = new WayOfDelivery
                {
                    Code = "BÅT",
                    Description = "Skärgårdsbåt"
                }
            };

            // Update the post
            FortnoxResponse<WayOfDeliveryRoot> fr = await config.fortnox_client.Update<WayOfDeliveryRoot>(post, "wayofdeliveries/BÅT");

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
            FortnoxResponse<WayOfDeliveryRoot> fr = await config.fortnox_client.Get<WayOfDeliveryRoot>("wayofdeliveries/BÅT");

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
            FortnoxResponse<WayOfDeliveriesRoot> fr = await config.fortnox_client.Get<WayOfDeliveriesRoot>("wayofdeliveries?limit=5&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("wayofdeliveries/BÅT");

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