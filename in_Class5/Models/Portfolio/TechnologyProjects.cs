using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace in_Class5.Models.Portfolio
{
    public class TechnologyProjects 
    {
        //using attributes...
        //these are data annotations
        [Key, Column(Order = 1) ]
        public string TechnoglyName { get; set; }

        [Key, Column(Order = 0)]
        public int ProjectId { get; set; }

        //these are basically "navigations properties"
        public virtual Technology Technology { get; set; }
        public virtual Project Project { get; set; }
    }
}
