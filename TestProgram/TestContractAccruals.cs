using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
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
                    CostAccount = "4518",
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
            FortnoxResponse<ContractAccrualRoot> fr = await config.fortnox_client.Add<ContractAccrualRoot>(post, "contractaccruals");

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
            FortnoxResponse<ContractAccrualRoot> fr = await config.fortnox_client.Update<ContractAccrualRoot>(post, "contractaccruals/1");

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
            FortnoxResponse<ContractAccrualRoot> fr = await config.fortnox_client.Get<ContractAccrualRoot>("contractaccruals/1");

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
            FortnoxResponse<ContractAccrualsRoot> fr = await config.fortnox_client.Get<ContractAccrualsRoot>("contractaccruals?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            FortnoxResponse<bool> fr = await config.fortnox_client.Delete("contractaccruals/1");

            // Log the error
            if (fr.model == false)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreEqual(true, fr.model);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace