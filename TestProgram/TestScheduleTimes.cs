using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            post = await config.fortnox_repository.Update<ScheduleTimeRoot>(config.client, post, "scheduletimes/1/2017-11-03");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to reset a post
        /// </summary>
        [TestMethod]
        public async Task TestResetPost()
        {
            // Update the post
            ScheduleTimeRoot post = await config.fortnox_repository.Action<ScheduleTimeRoot>(config.client, "scheduletimes/1/2017-11-03/resetday");

        } // End of the TestResetPost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ScheduleTimeRoot post = await config.fortnox_repository.Get<ScheduleTimeRoot>(config.client, "scheduletimes/1/2017-11-03");

            // Test evaluation
            Assert.AreNotEqual(null, post.ScheduleTime);

        } // End of the TestGetPost method

        #endregion

    } // End of the class

} // End of the namespace