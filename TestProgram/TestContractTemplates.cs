using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<ContractTemplateRoot>(config.client, post, "contracttemplates");

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
            post = await config.fortnox_repository.Update<ContractTemplateRoot>(config.client, post, "contracttemplates/1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ContractTemplateRoot post = await config.fortnox_repository.Get<ContractTemplateRoot>(config.client, "contracttemplates/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.ContractTemplate);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ContractTemplatesRoot post = await config.fortnox_repository.Get<ContractTemplatesRoot>(config.client, "contracttemplates?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.ContractTemplates.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace