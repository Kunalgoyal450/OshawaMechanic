using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OshawaMechanic.Models
{
    public class Coustmers
    {
        [Key]
        public int coustmerId { get; set; }

        public string coustmerName { get; set; }

        public int coustmerphoneNumber { get; set; }

        public string coustmerAddress { get; set; }

        public ICollection<Assignments> Assignments { get; set; }

    }
}
