using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestContracts
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestContracts()
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
            ContractRoot post = new ContractRoot
            {
                Contract = new Contract
                {
                    DocumentNumber = "2",
                    CustomerNumber = "10",
                    ContractDate = "2016-04-01",
                    PeriodStart = "2016-05-01",
                    PeriodEnd = "2016-05-31",
                    InvoiceRows = new List<InvoiceRow>
                    {
                        new InvoiceRow
                        {
                            ArticleNumber = "1",
                            DeliveredQuantity = 2M
                        },
                        new InvoiceRow
                        {
                            ArticleNumber = "2",
                            DeliveredQuantity = 3M
                        }
                    }
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<ContractRoot>(config.client, post, "contracts");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            ContractRoot post = new ContractRoot
            {
                Contract = new Contract
                {
                    DocumentNumber = "2",
                    CustomerNumber = "10",
                    ContractDate = "2016-04-01",
                    PeriodStart = "2016-05-01",
                    PeriodEnd = "2016-05-31",
                    InvoiceRows = new List<InvoiceRow>
                    {
                        new InvoiceRow
                        {
                            ArticleNumber = "1",
                            DeliveredQuantity = 5M
                        },
                        new InvoiceRow
                        {
                            ArticleNumber = "2",
                            DeliveredQuantity = 7M
                        }
                    }
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<ContractRoot>(config.client, post, "contracts/2");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ContractRoot post = await config.fortnox_repository.Get<ContractRoot>(config.client, "contracts/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.Contract);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ContractsRoot post = await config.fortnox_repository.Get<ContractsRoot>(config.client, "contracts?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Contracts.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace