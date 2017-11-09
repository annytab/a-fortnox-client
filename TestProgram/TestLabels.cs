using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestLabels
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestLabels()
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
            LabelRoot post = new LabelRoot
            {
                Label = new Label
                {
                    Description = "TEST2"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<LabelRoot>(config.client, post, "labels");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            LabelRoot post = new LabelRoot
            {
                Label = new Label
                {
                    Description = "TEST-UPDATED"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<LabelRoot>(config.client, post, "labels/1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            LabelsRoot post = await config.fortnox_repository.Get<LabelsRoot>(config.client, "labels?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Labels.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "labels/1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace