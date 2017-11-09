using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestSuppliers
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestSuppliers()
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
            SupplierRoot post = new SupplierRoot
            {
                Supplier = new Supplier
                {
                    SupplierNumber = "A500PP",
                    Name = "Test AB"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<SupplierRoot>(config.client, post, "suppliers");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            SupplierRoot post = new SupplierRoot
            {
                Supplier = new Supplier
                {
                    SupplierNumber = "A500PP",
                    Name = "Test AB",
                    CountryCode = "US"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<SupplierRoot>(config.client, post, "suppliers/A500PP");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            SupplierRoot post = await config.fortnox_repository.Get<SupplierRoot>(config.client, "suppliers/A500PP");

            // Test evaluation
            Assert.AreNotEqual(null, post.Supplier);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            SuppliersRoot post = await config.fortnox_repository.Get<SuppliersRoot>(config.client, "suppliers?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Suppliers.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace