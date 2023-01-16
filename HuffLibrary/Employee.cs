using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace HuffLibrary
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
            Subordinates= new List<Employee>();
        }

        public Employee()
        {
            Subordinates = new List<Employee>();
        }

        public List<Employee> FindSupervisors(Employee employee)
        {
            List<Employee> supervisorList = new List<Employee>();

            //recursive case
            if (employee.Supervisor != null)
            {
                supervisorList = FindSupervisors(employee.Supervisor);
                supervisorList.Add(employee.Supervisor);
            }
            
            return supervisorList;
        }
    }
}