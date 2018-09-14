using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestSupplierInvoices
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestSupplierInvoices()
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
            SupplierInvoiceRoot post = new SupplierInvoiceRoot
            {
                SupplierInvoice = new SupplierInvoice
                {
                    SupplierNumber = "5",
                    InvoiceDate = "2017-11-01",
                    DueDate = "2017-11-30",
                    Total = 10000,
                    VAT = 2000,
                    VATType = "NORMAL",
                    SalesType = "STOCK",
                    Currency = "SEK",
                    CurrencyRate = 1,
                    CurrencyUnit = 1,
                    SupplierInvoiceRows = new List<SupplierInvoiceRow>
                    {
                        new SupplierInvoiceRow
                        {
                            Account = "2440",
                            Code = "TOT",
                            AccountDescription = "Leverantörsskulder",
                            Debit = 0,
                            Credit = 10000,
                            Total = -10000
                        },
                        new SupplierInvoiceRow
                        {
                            Account = "2641",
                            Code = "VAT",
                            AccountDescription = "Ingående moms",
                            Debit = 2000,
                            Credit = 0,
                            Total = 2000
                        },
                        new SupplierInvoiceRow
                        {
                            Account = "6210",
                            Code = "PRE",
                            AccountDescription = "Telefoni",
                            Debit = 8000,
                            Credit = 0,
                            Total = 8000
                        }
                    }
                }
            };

            // Add the post
            FortnoxResponse<SupplierInvoiceRoot> fr = await config.fortnox_client.Add<SupplierInvoiceRoot>(post, "supplierinvoices");

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
            SupplierInvoiceRoot post = new SupplierInvoiceRoot
            {
                SupplierInvoice = new SupplierInvoice
                {
                    SupplierNumber = "1",
                    InvoiceDate = "2017-11-01",
                    DueDate = "2017-11-25",
                    Total = 10000,
                    VAT = 2000,
                    VATType = "NORMAL",
                    SalesType = "STOCK",
                    Currency = "SEK",
                    CurrencyRate = 1,
                    CurrencyUnit = 1,
                    SupplierInvoiceRows = new List<SupplierInvoiceRow>
                    {
                        new SupplierInvoiceRow
                        {
                            Account = "2440",
                            Code = "TOT",
                            AccountDescription = "Leverantörsskulder",
                            Debit = 0,
                            Credit = 10000,
                            Total = -10000
                        },
                        new SupplierInvoiceRow
                        {
                            Account = "2641",
                            Code = "VAT",
                            AccountDescription = "Ingående moms",
                            Debit = 2000,
                            Credit = 0,
                            Total = 2000
                            
                        },
                        new SupplierInvoiceRow
                        {
                            Account = "6250",
                            Code = "PRE",
                            AccountDescription = "Porto",
                            Debit = 8000,
                            Credit = 0,
                            Total = 8000,
                            ArticleNumber = "1",
                            Unit = "st",
                            Quantity = 1000,
                            Price = 8
                        }
                    }
                }
            };

            // Update the post
            FortnoxResponse<SupplierInvoiceRoot> fr = await config.fortnox_client.Update<SupplierInvoiceRoot>(post, "supplierinvoices/50");

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
            FortnoxResponse<SupplierInvoiceRoot> fr = await config.fortnox_client.Get<SupplierInvoiceRoot>("supplierinvoices/1");

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
            FortnoxResponse<SupplierInvoicesRoot> fr = await config.fortnox_client.Get<SupplierInvoicesRoot>("supplierinvoices?limit=5&page=1");

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