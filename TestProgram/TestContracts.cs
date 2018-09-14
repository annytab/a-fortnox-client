using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    DocumentNumber = "3",
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
            FortnoxResponse<ContractRoot> fr = await config.fortnox_client.Add<ContractRoot>(post, "contracts");

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
            ContractRoot post = new ContractRoot
            {
                Contract = new Contract
                {
                    DocumentNumber = "3",
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
            FortnoxResponse<ContractRoot> fr = await config.fortnox_client.Update<ContractRoot>(post, "contracts/3");

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
            FortnoxResponse<ContractRoot> fr = await config.fortnox_client.Get<ContractRoot>("contracts/1");

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
            FortnoxResponse<ContractsRoot> fr = await config.fortnox_client.Get<ContractsRoot>("contracts?limit=2&page=1");

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