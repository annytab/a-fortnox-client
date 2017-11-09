using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestArticles
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestArticles()
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
            ArticleRoot post = new ArticleRoot
            {
                Article = new Article
                {
                    Active = true,
                    ArticleNumber = "TEST-58878",
                    Description = "Testing testing"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<ArticleRoot>(config.client, post, "articles");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            ArticleRoot post = new ArticleRoot
            {
                Article = new Article
                {
                    Active = false,
                    ArticleNumber = "TEST-58878",
                    Description = "Updated Testing"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<ArticleRoot>(config.client, post, "articles/TEST-58878");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ArticleRoot post = await config.fortnox_repository.Get<ArticleRoot>(config.client, "articles/TEST-58878");

            // Test evaluation
            Assert.AreNotEqual(null, post.Article);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ArticlesRoot post = await config.fortnox_repository.Get<ArticlesRoot>(config.client, "articles?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Articles.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "articles/TEST-58878");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace