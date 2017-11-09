using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestLockedPeriod
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestLockedPeriod()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            LockedPeriodRoot post = await config.fortnox_repository.Get<LockedPeriodRoot>(config.client, "settings/lockedperiod");

            // Test evaluation
            Assert.AreNotEqual(null, post.LockedPeriod);

        } // End of the TestGetPost method

        #endregion

    } // End of the class

} // End of the namespace