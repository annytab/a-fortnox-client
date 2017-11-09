using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestCompanySettings
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestCompanySettings()
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
            CompanySettingsRoot post = await config.fortnox_repository.Get<CompanySettingsRoot>(config.client, "settings/company");

            // Test evaluation
            Assert.AreNotEqual(null, post.CompanySettings);

        } // End of the TestGetPost method

        #endregion

    } // End of the class

} // End of the namespace