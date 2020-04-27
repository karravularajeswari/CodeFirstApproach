using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    [Table("tblDepartments")]
    public class Departments
    {
        [Key]
        public int Did { get; set; }
        public string Dname { get; set; }
    }
}