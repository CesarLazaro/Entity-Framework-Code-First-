using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CodeFirst
{
    class Cat_Role
    {
        [Key]
        public int Cat_RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Statee { get; set; }



    }
}
