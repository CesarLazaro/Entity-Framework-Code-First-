using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
   class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Firt_Name { get; set; }
        public string Last_Name { get; set; }
        public string Mail { get; set; }
        public string BirthDate { get; set; }
        public string StartDate { get; set; }
        public int Statee { get; set; }
        public virtual Company Company { get; set; }

    }
}
