using System.Collections.Generic;

namespace Annytab.Fortnox.Client.V3
{
    /// <summary>
    /// This is the root class for employees
    /// </summary>
    public class EmployeesRoot
    {
        #region Variables

        public IList<Employee> Employees { get; set; }
        public MetaInformation MetaInformation { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EmployeesRoot()
        {
            this.Employees = null;
            this.MetaInformation = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This is the root class for employee
    /// </summary>
    public class EmployeeRoot
    {
        #region Variables

        public Employee Employee { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public EmployeeRoot()
        {
            this.Employee = null;

        } // End of the constructor

        #endregion

    } // End of the class

    /// <summary>
    /// This class represents an employee
    /// </summary>
    public class Employee
    {
        #region Variables

        public string EmployeeId { get; set; }
        public string PersonalIdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string EmploymentDate { get; set; }
        public string EmploymentForm { get; set; }
        public string SalaryForm { get; set; }
        public string JobTitle { get; set; }
        public string PersonelType { get; set; }
        public string ScheduleId { get; set; }
        public string ForaType { get; set; }
        public decimal? MonthlySalary { get; set; }
        public decimal? HourlyPay { get; set; }
        public string TaxAllowance { get; set; }
        public string TaxTable { get; set; }
        public string TaxColumn { get; set; }
        public decimal? NonRecurringTax { get; set; }
        public bool? Inactive { get; set; }
        public string ClearingNo { get; set; }
        public string BankAccountNo { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new post
        /// </summary>
        public Employee()
        {
            // Set values for instance variables
            this.EmployeeId = null;
            this.PersonalIdentityNumber = null;
            this.FirstName = null;
            this.LastName = null;
            this.FullName = null;
            this.Address1 = null;
            this.Address2 = null;
            this.PostCode = null;
            this.City = null;
            this.Country = null;
            this.Phone1 = null;
            this.Phone2 = null;
            this.Email = null;
            this.EmploymentDate = null;
            this.EmploymentForm = null;
            this.SalaryForm = null;
            this.JobTitle = null;
            this.PersonelType = null;
            this.ScheduleId = null;
            this.ForaType = null;
            this.MonthlySalary = null;
            this.HourlyPay = null;
            this.TaxAllowance = null;
            this.TaxTable = null;
            this.TaxColumn = null;
            this.NonRecurringTax = null;
            this.Inactive = null;
            this.ClearingNo = null;
            this.BankAccountNo = null;

        } // End of the constructor

        #endregion

    } // End of the class

} // End of the namespace