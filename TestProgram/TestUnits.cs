using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestUnits
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestUnits()
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
            UnitRoot post = new UnitRoot
            {
                Unit = new Unit
                {
                    Code = "XXX",
                    Description = "Tripple X"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<UnitRoot>(config.client, post, "units");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            UnitRoot post = new UnitRoot
            {
                Unit = new Unit
                {
                    Code = "XXX",
                    Description = "Testing"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<UnitRoot>(config.client, post, "units/XXX");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            UnitRoot post = await config.fortnox_repository.Get<UnitRoot>(config.client, "units/XXX");

            // Test evaluation
            Assert.AreNotEqual(null, post.Unit);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            UnitsRoot post = await config.fortnox_repository.Get<UnitsRoot>(config.client, "units?limit=5&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Units.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "units/XXX");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace