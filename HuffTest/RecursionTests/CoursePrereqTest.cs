using HuffLibrary.CourseRecursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffTest.RecursionTests
{
    public class CoursePrereqTest
    {
        [Fact]
        public void ShouldFindAllPrereqs()
        {
            List<Course> allCourses = CreateMockData();

            Assert.Equal(2, allCourses.Last().FindPrereqsForCourse(allCourses.Last(), new List<Course>()).Count);
        }

        public List<Course> CreateMockData()
        {
            List<Course> allCourses = new List<Course>();

            Course course1 = new Course
            {
                CourseId = 1,
                CourseName = "Test Course 1"
            };
            allCourses.Add(course1);

            Course course2 = new Course
            {
                CourseId = 2,
                CourseName = "Test Course 2",
                CoursePrereqs = new List<Prereq> { new Prereq { PrereqCourse = course1 } }
            };
            allCourses.Add(course2);

            Course course3 = new Course
            {
                CourseId = 3,
                CourseName = "Test Course 3",
                CoursePrereqs = new List<Prereq> { new Prereq { PrereqCourse = course2 } }
            };
            allCourses.Add(course3);

            Course course4 = new Course
            {
                CourseId = 4,
                CourseName = "Test Course 4",
                CoursePrereqs = new List<Prereq>() { new Prereq { PrereqCourse = course2 } }
            };
            allCourses.Add(course4);

            return allCourses;
        }
    }
}
