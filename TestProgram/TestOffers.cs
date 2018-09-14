using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestOffers
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestOffers()
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
            OfferRoot post = new OfferRoot
            {
                Offer = new Offer
                {
                    CustomerNumber = "10",
                    OfferRows = new List<OfferRow>
                    {
                        new OfferRow
                        {
                            ArticleNumber = "1",
                            Quantity = 8M,
                            Price = 34.45M
                        },
                        new OfferRow
                        {
                            ArticleNumber = "2",
                            Quantity = 4M
                        }
                    }
                }
            };

            // Add the post
            FortnoxResponse<OfferRoot> fr = await config.fortnox_client.Add<OfferRoot>(post, "offers");

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
            OfferRoot post = new OfferRoot
            {
                Offer = new Offer
                {
                    CustomerNumber = "11",
                    OfferRows = new List<OfferRow>
                    {
                        new OfferRow
                        {
                            ArticleNumber = "3",
                            Quantity = 50M,
                            Price = 34.45M
                        },
                        new OfferRow
                        {
                            ArticleNumber = "2",
                            Quantity = 4M
                        }
                    }
                }
            };

            // Update the post
            FortnoxResponse<OfferRoot> fr = await config.fortnox_client.Update<OfferRoot>(post, "offers/19");

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
            FortnoxResponse<OfferRoot> fr = await config.fortnox_client.Get<OfferRoot>("offers/17");

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
            FortnoxResponse<OffersRoot> fr = await config.fortnox_client.Get<OffersRoot>("offers?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace