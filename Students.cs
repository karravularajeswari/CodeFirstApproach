using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCPractice.Models
{
    [Table("tblStudents")]
    public class Students
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
        public Departments departments { get; set; }
    }
}