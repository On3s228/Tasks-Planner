using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner
{
    public class DefaultRepositories
    {
        public static Categories GetDefaultCategories()
        {
            Categories categories = new Categories
            {
                CategoriesList = new List<Category>()
            };
            Category c = new Category
            {
                Id = ++Categories.IdCounter,
                Name = Messages.DefaultCategoryName,
                Description = Messages.Empty,
            };
            categories.CategoriesList.Add(c);

            return categories;
        }
        public static UserTasks GetDefaultTasks(IRepository<Category> categories)
        {
            UserTasks tasks = new UserTasks
            {
                TasksList = new List<UserTask>()
            };
            Category c = categories.GetByID(0);
            UserTask t = new UserTask
            {
                Id = ++UserTasks.IdCounter,
                Name = Messages.DefaultTaskName,
                Description = Messages.DefaultPeriodicDesc,
                TaskDate = new DateTime(2021, 11, 23, 19, 30, 0),
                CategoriesID = new List<int>()
            };
            t.Period = 30000;
            UserTask t1 = new UserTask
            {
                Id = ++UserTasks.IdCounter,
                Name = Messages.DefaultTaskName,
                Description = Messages.DefaultTaskDesc,
                TaskDate = new DateTime(2022, 11, 24),
                CategoriesID = new List<int>()
            };
            t.CategoriesID.Add(c.Id);
            t1.CategoriesID.Add(c.Id);

            tasks.TasksList.Add(t);
            tasks.TasksList.Add(t1);


            return tasks;
        }
    }
}
