using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestAssets
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestAssets()
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
            AssetRoot post = new AssetRoot
            {
                Asset = new Asset
                {
                    Number = "RW4559",
                    Description = "Laptop ASUS 5000",
                    TypeId  = "1",
                    DepreciationMethod = "0",
                    AcquisitionValue = 20000M,
                    DepreciateToResidualValue = 4000M,
                    AcquisitionDate = "2018-09-01",
                    AcquisitionStart = "2018-10-01",
                    DepreciationFinal = "2022-12-31"
                }
            };

            // Add the post
            FortnoxResponse<AssetRoot> fr = await config.fortnox_client.Add<AssetRoot>(post, "assets");

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
            AssetRoot post = new AssetRoot
            {
                Asset = new Asset
                {
                    Number = "RW4556",
                    Description = "Laptop ASUS 5000 UPPDATERAD",
                    TypeId = "8",
                    DepreciationMethod = "0",
                    AcquisitionValue = 20000M,
                    DepreciateToResidualValue = 4000M,
                    AcquisitionDate = "2018-09-01",
                    AcquisitionStart = "2018-09-01",
                    DepreciationFinal = "2022-12-31"
                }
            };

            // Update the post
            FortnoxResponse<AssetRoot> fr = await config.fortnox_client.Update<AssetRoot>(post, "assets/2");

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
            FortnoxResponse<AssetRoot> fr = await config.fortnox_client.Get<AssetRoot>("assets/1");

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
            FortnoxResponse<AssetsRoot> fr = await config.fortnox_client.Get<AssetsRoot>("assets?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        /// <summary>
        /// Test to get a list of deprications
        /// </summary>
        [TestMethod]
        public async Task TestGetDepricationsList()
        {
            // Get a list
            FortnoxResponse<AssetsDepreciationRoot> fr = await config.fortnox_client.Get<AssetsDepreciationRoot>("assets/depreciations/2018-12-31");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetDepricationsList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("assets/1");

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