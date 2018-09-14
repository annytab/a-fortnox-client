using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestContractTemplates
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestContractTemplates()
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
            ContractTemplateRoot post = new ContractTemplateRoot
            {
                ContractTemplate = new ContractTemplate
                {
                    TemplateNumber = "2",
                    TemplateName = "6 Månader",
                    ContractLength = 6,
                    Continuous = false,
                    InvoiceInterval = 3,
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
                            DeliveredQuantity = 3M
                        }
                    }
                }
            };

            // Add the post
            FortnoxResponse<ContractTemplateRoot> fr = await config.fortnox_client.Add<ContractTemplateRoot>(post, "contracttemplates");

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
            ContractTemplateRoot post = new ContractTemplateRoot
            {
                ContractTemplate = new ContractTemplate
                {
                    TemplateName = "6 Månader",
                    ContractLength = 6,
                    Continuous = false,
                    InvoiceInterval = 2,
                    InvoiceRows = new List<InvoiceRow>
                    {
                        new InvoiceRow
                        {
                            ArticleNumber = "2",
                            DeliveredQuantity = 7M
                        }
                    }
                }
            };

            // Update the post
            FortnoxResponse<ContractTemplateRoot> fr = await config.fortnox_client.Update<ContractTemplateRoot>(post, "contracttemplates/1");

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
            FortnoxResponse<ContractTemplateRoot> fr = await config.fortnox_client.Get<ContractTemplateRoot>("contracttemplates/2");

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
            FortnoxResponse<ContractTemplatesRoot> fr = await config.fortnox_client.Get<ContractTemplatesRoot>("contracttemplates?limit=2&page=1");

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