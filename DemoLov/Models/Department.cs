using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

namespace DemoLov.Models
{
    public class Department
    {

        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Department")]
        public string DepartmentName { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string Location { get; set; }
    }
}