using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;
using System.Collections.Generic;

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
                    DocumentNumber = "100000",
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
            post = await config.fortnox_repository.Add<OrderRoot>(config.client, post, "orders");

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
                    DocumentNumber = "100000",
                    CustomerNumber = "2",
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
            post = await config.fortnox_repository.Update<OrderRoot>(config.client, post, "orders/100000");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            OrderRoot post = await config.fortnox_repository.Get<OrderRoot>(config.client, "orders/21");

            // Test evaluation
            Assert.AreNotEqual(null, post.Order);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            OrdersRoot post = await config.fortnox_repository.Get<OrdersRoot>(config.client, "orders?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Orders.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace