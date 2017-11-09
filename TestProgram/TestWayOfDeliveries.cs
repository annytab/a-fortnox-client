using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<WayOfDeliveryRoot>(config.client, post, "wayofdeliveries");

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
            post = await config.fortnox_repository.Update<WayOfDeliveryRoot>(config.client, post, "wayofdeliveries/BÅT");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            WayOfDeliveryRoot post = await config.fortnox_repository.Get<WayOfDeliveryRoot>(config.client, "wayofdeliveries/BÅT");

            // Test evaluation
            Assert.AreNotEqual(null, post.WayOfDelivery);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            WayOfDeliveriesRoot post = await config.fortnox_repository.Get<WayOfDeliveriesRoot>(config.client, "wayofdeliveries?limit=5&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.WayOfDeliveries.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "wayofdeliveries/BÅT");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace