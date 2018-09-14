using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestVouchers
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestVouchers()
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
            VoucherRoot post = new VoucherRoot
            {
                Voucher = new Voucher
                {
                    VoucherSeries = "A",
                    TransactionDate = "2017-11-09",
                    Description = "Computer",
                    VoucherRows = new List<VoucherRow>
                    {
                        new VoucherRow
                        {
                            Account = "1930",
                            Debit = 0M,
                            Credit = 12500M
                        },
                        new VoucherRow
                        {
                            Account = "2641",
                            Debit = 2500M,
                            Credit = 0
                        },
                        new VoucherRow
                        {
                            Account = "5410",
                            Debit = 10000M,
                            Credit = 0
                        }
                    }
                }
            };

            // Add the post
            FortnoxResponse<VoucherRoot> fr = await config.fortnox_client.Add<VoucherRoot>(post, "vouchers");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<VoucherRoot> fr = await config.fortnox_client.Get<VoucherRoot>("vouchers/D/5?financialyear=2");

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
        public async Task TestGetAll()
        {
            // Get a list
            FortnoxResponse<VouchersRoot> fr = await config.fortnox_client.Get<VouchersRoot>("vouchers?limit=5&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetAll method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetAllInSeries()
        {
            // Get a list
            FortnoxResponse<VouchersRoot> fr = await config.fortnox_client.Get<VouchersRoot>("vouchers/sublist/B?limit=5&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetAllInSeries method

        #endregion

    } // End of the class

} // End of the namespace