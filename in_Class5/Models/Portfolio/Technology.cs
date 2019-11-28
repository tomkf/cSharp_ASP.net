using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace in_Class5.Models.Portfolio
{
    public class Technology
    {
        //Key notation to assign Primary Key
        //Optional DatabaseGenerated Attribute
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }

        //Navigation Properties
        //Child Tables
        public virtual ICollection<TechnologyProjects> TechnologyProjects { get; set; }
    }
}
