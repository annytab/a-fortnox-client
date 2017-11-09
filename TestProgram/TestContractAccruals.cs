using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestContractAccruals
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestContractAccruals()
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
            ContractAccrualRoot post = new ContractAccrualRoot
            {
                ContractAccrual = new ContractAccrual
                {
                    AccrualAccount = "2990",
                    CostAccount = "3990",
                    DocumentNumber = "1",
                    Description = "TESTAR",
                    Total = 50000M,
                    AccrualRows = new List<AccrualRow>
                    {
                       new AccrualRow
                       {
                           Account = "2990",
                           Credit = 0M,
                           Debit = 5000M
                       },
                       new AccrualRow
                       {
                           Account = "3990",
                           Credit = 5000M,
                           Debit = 0
                       }
                    }
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<ContractAccrualRoot>(config.client, post, "contractaccruals");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            ContractAccrualRoot post = new ContractAccrualRoot
            {
                ContractAccrual = new ContractAccrual
                {
                    AccrualAccount = "2990",
                    CostAccount = "3600",
                    Total = 50000M,
                    AccrualRows = new List<AccrualRow>
                    {
                       new AccrualRow
                       {
                           Account = "2990",
                           Credit = 0M,
                           Debit = 5000M
                       },
                       new AccrualRow
                       {
                           Account = "3600",
                           Credit = 5000M,
                           Debit = 0
                       }
                    }
                }
            };
            // Update the post
            post = await config.fortnox_repository.Update<ContractAccrualRoot>(config.client, post, "contractaccruals/1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ContractAccrualRoot post = await config.fortnox_repository.Get<ContractAccrualRoot>(config.client, "contractaccruals/1");

            // Test evaluation
            Assert.AreNotEqual(null, post.ContractAccrual);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ContractAccrualsRoot post = await config.fortnox_repository.Get<ContractAccrualsRoot>(config.client, "contractaccruals?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.ContractAccruals.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "contractaccruals/1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace