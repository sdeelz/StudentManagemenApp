using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagemenApp.Models
{
    public class MarkDisplayViewModel
    {
        public Student student { get; set; }

        public Mark mark { get; set; }

        public double TotalMarks { get; set; }
    }
}
