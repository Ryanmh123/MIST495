using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffLibrary.CourseRecursion
{
    public class Prereq
    {
        [Key]
        public int PrereqId { get; set; }
        public Course PrereqCourse { get; set; }
    }
}
