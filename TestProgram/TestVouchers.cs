using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Add<VoucherRoot>(config.client, post, "vouchers");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            VoucherRoot post = await config.fortnox_repository.Get<VoucherRoot>(config.client, "vouchers/D/5?financialyear=2");

            // Test evaluation
            Assert.AreNotEqual(null, post.Voucher);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetAll()
        {
            // Get a list
            VouchersRoot post = await config.fortnox_repository.Get<VouchersRoot>(config.client, "vouchers?limit=5&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Vouchers.Count);

        } // End of the TestGetAll method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetAllInSeries()
        {
            // Get a list
            VouchersRoot post = await config.fortnox_repository.Get<VouchersRoot>(config.client, "vouchers/sublist/B?limit=5&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Vouchers.Count);

        } // End of the TestGetAllInSeries method

        #endregion

    } // End of the class

} // End of the namespace