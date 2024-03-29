using System;
using System.ComponentModel.DataAnnotations;

namespace demo1.Models
{
    public class Dependents
    {
        [Key]
        public int dependent_id { get; set; }
        public int employee_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string relationship { get; set; }
    }
}