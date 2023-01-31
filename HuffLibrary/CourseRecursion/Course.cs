using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffLibrary.CourseRecursion
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Prereq> CoursePrereqs { get; set; }

        public Course()
        {
            CoursePrereqs = new List<Prereq>();
        }

        public List<Course> FindPrereqsForCourse(Course course, List<Course> allCoursePrereqs)
        {

            foreach(Prereq prereq in course.CoursePrereqs)
            {
                if (course.CoursePrereqs != null)
                {
                    allCoursePrereqs = FindPrereqsForCourse(prereq.PrereqCourse, allCoursePrereqs);
                    allCoursePrereqs.Add(prereq.PrereqCourse);
                }
            }

            return allCoursePrereqs;
        }
    }
}
