using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos
{
    public class Repositories
    {
        public IRepository<Category>? CategoriesRepository { get; private set; }
        public IRepository<UserTask>? TasksRepository { get; private set; }
        public Repositories(string appPath)
        {
            CategoriesRepository = new CategoriesRepository(appPath);
            TasksRepository = new TasksRepository(appPath, CategoriesRepository);
        }
    }
}
