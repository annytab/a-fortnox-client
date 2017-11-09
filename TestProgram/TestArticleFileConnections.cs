using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestArticleFileConnections
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestArticleFileConnections()
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
            ArticleFileConnectionRoot post = new ArticleFileConnectionRoot
            {
                ArticleFileConnection = new ArticleFileConnection
                {
                    FileId = "017618f5-eb3b-45d0-864e-4509fcbe07c5",
                    ArticleNumber = "1"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<ArticleFileConnectionRoot>(config.client, post, "articlefileconnections");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ArticleFileConnectionRoot post = await config.fortnox_repository.Get<ArticleFileConnectionRoot>(config.client, "articlefileconnections/017618f5-eb3b-45d0-864e-4509fcbe07c5");

            // Test evaluation
            Assert.AreNotEqual(null, post.ArticleFileConnection);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ArticleFileConnectionsRoot post = await config.fortnox_repository.Get<ArticleFileConnectionsRoot>(config.client, "articlefileconnections?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.ArticleFileConnections.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "articlefileconnections/017618f5-eb3b-45d0-864e-4509fcbe07c5");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace