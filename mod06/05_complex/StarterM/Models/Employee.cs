using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM.Models
{
    public class WorkExperience
    {
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Years")]
        public int Years { get; set; }
    }


    public class Employee
    {
        [Display(Name = "Employee Id")]
        public int EmployeeId { get; set; }
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [BindNever]
        public DateTime? BirthDate { get; set; }

        public WorkExperience  Experience { get; set; }

        [Display(Name = "Personal Interests")]
        public string[] Interests { get; set; }


    }
}
