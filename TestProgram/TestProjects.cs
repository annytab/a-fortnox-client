using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestProjects
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestProjects()
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
            ProjectRoot post = new ProjectRoot
            {
                Project = new Project
                {
                    ProjectNumber = "A2",
                    Description = "Second project",
                    StartDate = "2017-11-01",
                    EndDate = "2019-03-31",
                    Status = "ONGOING"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<ProjectRoot>(config.client, post, "projects");

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            ProjectRoot post = new ProjectRoot
            {
                Project = new Project
                {
                    ProjectNumber = "A1",
                    Description = "First project",
                    StartDate = "2017-11-01",
                    EndDate = "2017-11-08",
                    Status = "COMPLETED"
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<ProjectRoot>(config.client, post, "projects/A1");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            ProjectRoot post = await config.fortnox_repository.Get<ProjectRoot>(config.client, "projects/A1");

            // Test evaluation
            Assert.AreNotEqual(null, post.Project);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            ProjectsRoot post = await config.fortnox_repository.Get<ProjectsRoot>(config.client, "projects?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Projects.Count);

        } // End of the TestGetList method

        /// <summary>
        /// Test to delete a post
        /// </summary>
        [TestMethod]
        public async Task TestDeletePost()
        {
            // Get a list
            bool success = await config.fortnox_repository.Delete(config.client, "projects/A1");

            // Test evaluation
            Assert.AreEqual(true, success);

        } // End of the TestDeletePost method

        #endregion

    } // End of the class

} // End of the namespace