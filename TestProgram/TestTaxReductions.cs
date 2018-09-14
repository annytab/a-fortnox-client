using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
            FortnoxResponse<TaxReductionRoot> fr = await config.fortnox_client.Add<TaxReductionRoot>(post, "taxreductions");

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
            FortnoxResponse<TaxReductionRoot> fr = await config.fortnox_client.Update<TaxReductionRoot>(post, "taxreductions/12");

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
            FortnoxResponse<TaxReductionRoot> fr = await config.fortnox_client.Get<TaxReductionRoot>("taxreductions/13");

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
            FortnoxResponse<TaxReductionsRoot> fr = await config.fortnox_client.Get<TaxReductionsRoot>("taxreductions?limit=10&page=1");

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
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("taxreductions/12");

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