using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestCustomers
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestCustomers()
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
            CustomerRoot post = new CustomerRoot
            {
                Customer = new Customer
                {
                    CustomerNumber = "TEST-588",
                    Name = "Testbolaget",
                    Email = "test@testbolaget.se"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<CustomerRoot>(config.client, post, "customers");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            CustomerRoot post = new CustomerRoot
            {
                Customer = new Customer
                {
                    CustomerNumber = "TEST-588",
                    Name = "Testbolaget AAA",
                    Email = "test@testbolaget.se",
                    CountryCode = "NO",
                    Address1 = "Test 550"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<CustomerRoot>(config.client, post, "customers/TEST-588");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            CustomerRoot post = await config.fortnox_repository.Get<CustomerRoot>(config.client, "customers/TEST-588");

            // Test evaluation
            Assert.AreNotEqual(null, post.Customer);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            CustomersRoot post = await config.fortnox_repository.Get<CustomersRoot>(config.client, "customers?email=test@testbolaget.se&limit=5&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Customers.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "customers/TEST-588");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace