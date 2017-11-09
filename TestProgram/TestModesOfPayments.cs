using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestModesOfPayments
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestModesOfPayments()
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
            ModeOfPaymentRoot post = new ModeOfPaymentRoot
            {
                ModeOfPayment = new ModeOfPayment
                {
                    Code = "LB",
                    Description = "Bankgiro LB",
                    AccountNumber = "1940"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<ModeOfPaymentRoot>(config.client, post, "modesofpayments");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            ModeOfPaymentRoot post = new ModeOfPaymentRoot
            {
                ModeOfPayment = new ModeOfPayment
                {
                    Code = "LB",
                    Description = "Bankgiro LB",
                    AccountNumber = "1930"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<ModeOfPaymentRoot>(config.client, post, "modesofpayments/LB");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ModeOfPaymentRoot post = await config.fortnox_repository.Get<ModeOfPaymentRoot>(config.client, "modesofpayments/LB");

            // Test evaluation
            Assert.AreNotEqual(null, post.ModeOfPayment);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ModesOfPaymentsRoot post = await config.fortnox_repository.Get<ModesOfPaymentsRoot>(config.client, "modesofpayments?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.ModesOfPayments.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace