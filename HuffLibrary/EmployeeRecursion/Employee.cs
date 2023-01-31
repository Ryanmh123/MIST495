using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace HuffLibrary.Employee
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public Employee Supervisor { get; set; }
        public List<Employee> Subordinates { get; set; }

        public Employee(string empName)
        {
            EmployeeName = empName;
            Subordinates = new List<Employee>();
        }

        public Employee()
        {
            Subordinates = new List<Employee>();
        }

        public List<Employee> FindSupervisors(Employee employee, List<Employee> supervisorList)
        {
            //recursive case
            if (employee.Supervisor != null)
            {
                supervisorList = FindSupervisors(employee.Supervisor, supervisorList);
                supervisorList.Add(employee.Supervisor);
            }

            return supervisorList;
        }

        //public List<Employee> FindSupervisors(Employee employee, List<Employee> supervisorList)
        //{
        //    //List<Employee> supervisorList = new List<Employee>();

        //    //recursive case
        //    if (this.Supervisor != null)
        //    {
        //        supervisorList = FindSupervisors(supervisorList);
        //        supervisorList.Add(this.Supervisor);
        //    }

        //    return supervisorList;
        //}

        public static List<Employee> CreateMockData()
        {
            List<Employee> mockData = new List<Employee>();

            Employee emp = new Employee { EmployeeName = "Tom Moran" };
            mockData.Add(emp);
            emp = new Employee { EmployeeName = "Robert Phipps", Supervisor = emp };
            mockData.Add(emp);
            emp = new Employee { EmployeeName = "Cody Mitchell", Supervisor = emp };
            mockData.Add(emp);
            emp = new Employee { EmployeeName = "Ryan Huff", Supervisor = emp };
            mockData.Add(emp);

            return mockData;
        }
    }
}