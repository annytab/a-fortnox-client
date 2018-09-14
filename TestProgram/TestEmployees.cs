using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.Logging;
using Annytab.Fortnox.Client.V3;

namespace TestProgram
{
    [TestClass]
    public class TestEmployees
    {
        #region Variables

        private Config config { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new test instance
        /// </summary>
        public TestEmployees()
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
            EmployeeRoot post = new EmployeeRoot
            {
                Employee = new Employee
                {
                    EmployeeId = "TEST-100",
                    PersonalIdentityNumber = "8206067020",
                    FirstName = "Nils",
                    LastName = "Svensson",
                    EmploymentDate = "2017-11-06"
                }
            };

            // Add the post
            FortnoxResponse<EmployeeRoot> fr = await config.fortnox_client.Add<EmployeeRoot>(post, "employees");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestAddPost method

        /// <summary>
        /// Test to update a post
        /// </summary>
        [TestMethod]
        public async Task TestUpdatePost()
        {
            // Create a post
            EmployeeRoot post = new EmployeeRoot
            {
                Employee = new Employee
                {
                    EmployeeId = "TEST-100",
                    PersonalIdentityNumber = "8206067020",
                    FirstName = "Nils",
                    LastName = "Svensson",
                    EmploymentDate = "2017-11-06",
                    MonthlySalary = 20000M
                }
            };

            // Update the post
            FortnoxResponse<EmployeeRoot> fr = await config.fortnox_client.Update<EmployeeRoot>(post, "employees/TEST-100");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            FortnoxResponse<EmployeeRoot> fr = await config.fortnox_client.Get<EmployeeRoot>("employees/TEST-100");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            FortnoxResponse<EmployeesRoot> fr = await config.fortnox_client.Get<EmployeesRoot>("employees?limit=2&page=1");

            // Log the error
            if (fr.model == null)
            {
                config.logger.LogError(fr.error);
            }

            // Test evaluation
            Assert.AreNotEqual(null, fr.model);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace