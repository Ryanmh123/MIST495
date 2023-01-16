using HuffLibrary;

namespace HuffTest
{
    public class EmployeeTest
    {
        [Fact]
        public void ShouldCalculateNumberOfSupervisorsInChain()
        {
            List<Employee> empList = CreateMockData();

            Assert.Equal(3, empList.Last().FindSupervisors(empList.Last()).Count);
        }

        public List<Employee> CreateMockData()
        {
            List<Employee> mockData = new List<Employee>();

            Employee emp1 = new Employee { EmployeeName = "Tom Moran" };
            Employee emp2 = new Employee { EmployeeName = "Robert Phipps", Supervisor = emp1 };
            Employee emp3 = new Employee { EmployeeName = "Cody Mitchell", Supervisor = emp2 };
            Employee emp4= new Employee { EmployeeName = "Ryan Huff", Supervisor= emp3 };

            emp1.Subordinates.Add(emp2);
            emp1.Subordinates.Add(emp3);
            emp1.Subordinates.Add(emp4);

            emp2.Subordinates.Add(emp3);
            emp2.Subordinates.Add(emp4);

            mockData.Add(emp1);
            mockData.Add(emp2);
            mockData.Add(emp3);
            mockData.Add(emp4);

            return mockData;
        }
    }
}