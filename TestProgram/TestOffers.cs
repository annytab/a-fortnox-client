using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<OfferRoot>(config.client, post, "offers");

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
                    CustomerNumber = "10",
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
            post = await config.fortnox_repository.Update<OfferRoot>(config.client, post, "offers/1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            OfferRoot post = await config.fortnox_repository.Get<OfferRoot>(config.client, "offers/16");

            // Test evaluation
            Assert.AreNotEqual(null, post.Offer);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            OffersRoot post = await config.fortnox_repository.Get<OffersRoot>(config.client, "offers?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Offers.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace