using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHR.Models
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime DOB { get; set; }
        public string salary { get; set; }
    }
}