using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestAccessToken
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestAccessToken()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to get an access token
        /// </summary>
        [TestMethod]
        public async Task TestGetAccessToken()
        {
            if(config.settings.GetSection("FortnoxOptions")["AccessToken"] == "")
            {
                // Get an access token from fortnox
                AuthorizationResponse response = await FortnoxRepository.GetAccessToken(config.settings.GetSection("FortnoxOptions")["AuthorizationCode"], config.settings.GetSection("FortnoxOptions")["ClientSecret"]);

                // Test evaluation
                Assert.AreEqual(true, response.success);
                Assert.AreNotEqual("", response.message);
            }

        } // End of the TestGetAccessToken method

        #endregion

    } // End of the class

} // End of the namespace