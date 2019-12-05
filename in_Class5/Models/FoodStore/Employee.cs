using System;
using System.Collections.Generic;

namespace in_Class5.Models.FoodStore
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Branch { get; set; }

        public virtual Store BranchNavigation { get; set; }
    }
}
