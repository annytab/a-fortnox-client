using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestOrders
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestOrders()
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
            OrderRoot post = new OrderRoot
            {
                Order = new Order
                {
                    DocumentNumber = "100001",
                    CustomerNumber = "2",
                    OrderRows = new List<OrderRow>
                    {
                        new OrderRow
                        {
                            ArticleNumber = "1",
                            OrderedQuantity = 10M,
                            DeliveredQuantity = 8M,
                            Price = 34.45M,
                            Unit = "st"
                        },
                        new OrderRow
                        {
                            ArticleNumber = "2",
                            OrderedQuantity = 5M,
                            DeliveredQuantity = 5M,
                        }
                    }
                }
            };

            // Add the post
            FortnoxResponse<OrderRoot> fr = await config.fortnox_client.Add<OrderRoot>(post, "orders");

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
            OrderRoot post = new OrderRoot
            {
                Order = new Order
                {
                    DocumentNumber = "100001",
                    CustomerNumber = "10",
                    OrderRows = new List<OrderRow>
                    {
                        new OrderRow
                        {
                            ArticleNumber = "1",
                            OrderedQuantity = 20M,
                            DeliveredQuantity = 15M,
                            Unit = "h"
                        },
                        new OrderRow
                        {
                            ArticleNumber = "3",
                            OrderedQuantity = 10M,
                            DeliveredQuantity = 4M,
                        }
                    }
                }
            };

            // Update the post
            FortnoxResponse<OrderRoot> fr = await config.fortnox_client.Update<OrderRoot>(post, "orders/100001");

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
            FortnoxResponse<OrderRoot> fr = await config.fortnox_client.Get<OrderRoot>("orders/21");

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
            FortnoxResponse<OrdersRoot> fr = await config.fortnox_client.Get<OrdersRoot>("orders?limit=2&page=1");

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