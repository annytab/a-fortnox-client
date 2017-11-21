using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestTrustedEmailSenders
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestTrustedEmailSenders()
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
            TrustedSenderRoot post = new TrustedSenderRoot
            {
                TrustedSender = new EmailSender
                {
                    Email = "info@doxservr.se"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<TrustedSenderRoot>(config.client, post, "emailsenders/trusted");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            EmailSendersRoot post = await config.fortnox_repository.Get<EmailSendersRoot>(config.client, "emailsenders?limit=2&page=1");
            //EmailSendersRoot post = await config.fortnox_repository.Get<EmailSendersRoot>(config.client, "emailsenders");

            // Test evaluation
            Assert.AreNotEqual(0, post.EmailSenders.TrustedSenders.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "emailsenders/trusted/1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace