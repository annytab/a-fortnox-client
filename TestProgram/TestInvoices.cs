using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;
using System.IO;

namespace TestProgram
{
    [TestClass]
    public class TestInvoices
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestInvoices()
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
            InvoiceRoot post = new InvoiceRoot
            {
                Invoice = new Invoice
                {
                    CustomerNumber = "333333333333333333",
                    InvoiceRows = new List<InvoiceRow>
                    {
                        new InvoiceRow
                        {
                            ArticleNumber = "1",
                            DeliveredQuantity = 8M
                        },
                        new InvoiceRow
                        {
                            ArticleNumber = "2",
                            DeliveredQuantity = 4M
                        }
                    }
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<InvoiceRoot>(config.client, post, "invoices");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            InvoiceRoot post = new InvoiceRoot
            {
                Invoice = new Invoice
                {
                    CustomerNumber = "1",
                    InvoiceRows = new List<InvoiceRow>
                    {
                        new InvoiceRow
                        {
                            ArticleNumber = "3",
                            DeliveredQuantity = 50M
                        }
                    }
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<InvoiceRoot>(config.client, post, "invoices/88");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to bookkeep a post
        /// </summary>
        [TestMethod]
        public async Task TestBookkeep()
        {
            // Run an action
            InvoiceRoot post = await config.fortnox_repository.Action<InvoiceRoot>(config.client, "invoices/88/bookkeep");

        } // End of the TestBookkeep method

        /// <summary>
        /// Test to preview a post
        /// </summary>
        [TestMethod]
        public async Task TestPreview()
        {
            // Create a file stream
            using (FileStream fileStream = System.IO.File.OpenWrite("D:\\Bilder\\invoice-26.pdf"))
            {
                // Get the file
                await config.fortnox_repository.DownloadFile(config.client, fileStream, "invoices/26/preview");
            }

        } // End of the TestPreview method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            InvoiceRoot post = await config.fortnox_repository.Get<InvoiceRoot>(config.client, "invoices/2");

            // Test evaluation
            Assert.AreNotEqual(null, post.Invoice);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            InvoicesRoot post = await config.fortnox_repository.Get<InvoicesRoot>(config.client, "invoices?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Invoices.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace