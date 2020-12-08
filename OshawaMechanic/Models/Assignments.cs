using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace OshawaMechanic.Models
{
    public class Assignments
    {
        [Key]
        public int assignmentId { get; set; }

        public int coustmerId { get; set; }
        public Coustmers Coustmers { get; set; }

        public string employeeId { get; set; }
        public Employees Employees { get; set; }

    }
}
