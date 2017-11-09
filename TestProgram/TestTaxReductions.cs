using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestTaxReductions
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestTaxReductions()
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
            TaxReductionRoot post = new TaxReductionRoot
            {
                TaxReduction = new TaxReduction
                {
                    AskedAmount = 1M,
                    CustomerName = "Stefan Andersson",
                    ReferenceDocumentType = "INVOICE",
                    ReferenceNumber = "26",
                    SocialSecurityNumber = "810812-1172"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<TaxReductionRoot>(config.client, post, "taxreductions");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            TaxReductionRoot post = new TaxReductionRoot
            {
                TaxReduction = new TaxReduction
                {
                    AskedAmount = 4000M,
                    CustomerName = "Nils Nilsson",
                    ReferenceDocumentType = "INVOICE",
                    ReferenceNumber = "26",
                    SocialSecurityNumber = "810812-1172"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<TaxReductionRoot>(config.client, post, "taxreductions/7");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            TaxReductionRoot post = await config.fortnox_repository.Get<TaxReductionRoot>(config.client, "taxreductions/7");

            // Test evaluation
            Assert.AreNotEqual(null, post.TaxReduction);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            TaxReductionsRoot post = await config.fortnox_repository.Get<TaxReductionsRoot>(config.client, "taxreductions?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.TaxReductions.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "taxreductions/7");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace