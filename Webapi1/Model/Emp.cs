using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi1.Model
{
    public class Emp
    {
        [Key]
        public int Empid { get; set; }

        [Required(ErrorMessage = "Please enetr Name")]
        public string EName { get; set; }


        [Required(ErrorMessage = "Please enetr Email")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Please enetr Mobile no")]
        public string Mobile { get; set; }



        [Required(ErrorMessage = "Please enetr Age")]
        [Range(20, 50)]
        public int Age { get; set; }



        [Required(ErrorMessage = "Please Specify your Gender")]
        public string Gender { get; set; }
        public string Salary { get; set; }
    }
}

