using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestTrustedDomains
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestTrustedDomains()
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
            TrustedDomainRoot post = new TrustedDomainRoot
            {
                TrustedDomain = new TrustedDomain
                {
                    Domain = "doxservr.com"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<TrustedDomainRoot>(config.client, post, "emailtrusteddomains");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            TrustedDomainRoot post = await config.fortnox_repository.Get<TrustedDomainRoot>(config.client, "emailtrusteddomains/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.TrustedDomain);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            TrustedDomainsRoot post = await config.fortnox_repository.Get<TrustedDomainsRoot>(config.client, "emailtrusteddomains?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.TrustedDomains.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "emailtrusteddomains/1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace