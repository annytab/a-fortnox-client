using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestScheduleTimes
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestScheduleTimes()
        {
            this.config = new Config();

        } // End of the constructor

        #endregion

        #region Methods

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            ScheduleTimeRoot post = new ScheduleTimeRoot
            {
                ScheduleTime = new ScheduleTime
                {
                    Hours = 12M
                }
            };

            // Update the post
            FortnoxResponse<ScheduleTimeRoot> fr = await config.fortnox_client.Update<ScheduleTimeRoot>(post, "scheduletimes/2/2018-01-06");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to reset a post
        /// </summary>
        [TestMethod]
        public async Task TestResetPost()
        {
            // Update the post
            FortnoxResponse<ScheduleTimeRoot> fr = await config.fortnox_client.Action<ScheduleTimeRoot>("scheduletimes/2/2018-01-06/resetday");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestResetPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<ScheduleTimeRoot> fr = await config.fortnox_client.Get<ScheduleTimeRoot>("scheduletimes/2/2018-01-06");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetPost method

        #endregion

    } // End of the class

} // End of the namespace