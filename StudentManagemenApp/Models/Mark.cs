using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagemenApp.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }

        public int StudentId { get; set; }


        public double English { get; set; }
        
        public double Maths { get; set; }
        
        public double Science { get; set; }

    }
}
