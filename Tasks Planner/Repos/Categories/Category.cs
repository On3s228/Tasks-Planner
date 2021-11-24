using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos.Categories
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<UserTask> Tasks { get; set; }
        public Category() { }
    }
}
