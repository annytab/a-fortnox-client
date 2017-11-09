using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestCostCenters
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestCostCenters()
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
            CostCenterRoot post = new CostCenterRoot
            {
                CostCenter = new CostCenter
                {
                    Active = true,
                    Code = "TT2",
                    Description = "TT department 2"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<CostCenterRoot>(config.client, post, "costcenters");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            CostCenterRoot post = new CostCenterRoot
            {
                CostCenter = new CostCenter
                {
                    Active = true,
                    Code = "TT1",
                    Description = "TT ONE"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<CostCenterRoot>(config.client, post, "costcenters/TT1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            CostCenterRoot post = await config.fortnox_repository.Get<CostCenterRoot>(config.client, "costcenters/TT1");

            // Test evaluation
            Assert.AreNotEqual(null, post.CostCenter);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            CostCentersRoot post = await config.fortnox_repository.Get<CostCentersRoot>(config.client, "costcenters?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.CostCenters.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "costcenters/TT1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace