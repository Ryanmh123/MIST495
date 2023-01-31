using HuffLibrary.Employee;

namespace HuffTest.RecursionTests
{
    public class EmployeeTest
    {
        [Fact]
        public void ShouldCalculateNumberOfSupervisorsInChain()
        {
            List<Employee> empList = CreateMockData();

            Assert.Equal(3, empList.Last().FindSupervisors(empList.Last(), new List<Employee>()).Count);
        }

        public List<Employee> CreateMockData()
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