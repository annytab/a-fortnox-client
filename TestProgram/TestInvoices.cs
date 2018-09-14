using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

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
                    CustomerNumber = "TEST-FREDDE",
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
            FortnoxResponse<InvoiceRoot> fr = await config.fortnox_client.Add<InvoiceRoot>(post, "invoices");

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
            FortnoxResponse<InvoiceRoot> fr = await config.fortnox_client.Update<InvoiceRoot>(post, "invoices/8");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to bookkeep a post
        /// </summary>
        [TestMethod]
        public async Task TestBookkeep()
        {
            // Run an action
            FortnoxResponse<InvoiceRoot> fr = await config.fortnox_client.Action<InvoiceRoot>("invoices/7/bookkeep");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestBookkeep method

        /// <summary>
        /// Test to preview a post
        /// </summary>
        [TestMethod]
        public async Task TestPreview()
        {
            // Create a file stream
            using (FileStream fileStream = System.IO.File.OpenWrite("D:\\Bilder\\invoice-8.pdf"))
            {
                // Get the file
                FortnoxResponse<bool> fr = await config.fortnox_client.DownloadFile(fileStream, "invoices/8/preview");

                // Log the error
                if (fr.model == false)
                {
                    config.logger.LogError(fr.error);
                }

                // Test evaluation
                Assert.AreEqual(true, fr.model);
            }

        } // End of the TestPreview method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<InvoiceRoot> fr = await config.fortnox_client.Get<InvoiceRoot>("invoices/8");

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
            FortnoxResponse<InvoicesRoot> fr = await config.fortnox_client.Get<InvoicesRoot>("invoices?limit=5&page=1");

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