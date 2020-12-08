using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace OshawaMechanic.Models
{
    public class Employees
    {
        [Key]
        public int employeeId { get; set; }

        public string employeeName { get; set; }

        public int phoneNumber { get; set; }

        public string employeeAddress { get; set; }

        public ICollection<Assignments> Assignments { get; set; }
    }
}
