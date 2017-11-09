using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                    PersonalIdentityNumber = "555555-88888",
                    FirstName = "Nils",
                    LastName = "Svensson",
                    EmploymentDate = "2017-11-06"
                }
            };

            // Add the post
            post = await config.fortnox_repository.Add<EmployeeRoot>(config.client, post, "employees");

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
                    PersonalIdentityNumber = "555555-88888",
                    FirstName = "Nils",
                    LastName = "Svensson",
                    EmploymentDate = "2017-11-06",
                    MonthlySalary = 20000M
                }
            };

            // Update the post
            post = await config.fortnox_repository.Update<EmployeeRoot>(config.client, post, "employees/TEST-100");

        } // End of the TestUpdatePost method

        /// <summary>
        /// Test to get a post
        /// </summary>
        [TestMethod]
        public async Task TestGetPost()
        {
            // Get a post
            EmployeeRoot post = await config.fortnox_repository.Get<EmployeeRoot>(config.client, "employees/TEST-100");

            // Test evaluation
            Assert.AreNotEqual(null, post.Employee);

        } // End of the TestGetPost method

        /// <summary>
        /// Test to get a list
        /// </summary>
        [TestMethod]
        public async Task TestGetList()
        {
            // Get a list
            EmployeesRoot post = await config.fortnox_repository.Get<EmployeesRoot>(config.client, "employees?limit=2&page=1");

            // Test evaluation
            Assert.AreNotEqual(0, post.Employees.Count);

        } // End of the TestGetList method

        #endregion

    } // End of the class

} // End of the namespace