using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace in_Class5.Models.Portfolio
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

        //Navigation Properties
        //Child Tables
        public virtual ICollection<TechnologyProjects> TechnologyProjects { get; set; }

    }
}
