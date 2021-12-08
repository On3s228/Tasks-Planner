using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
                CategoriesList = new ObservableCollection<Category>()
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
                TasksList = new ObservableCollection<UserTask>()
            };
            Category c = categories.GetByIndex(0);
            UserTask t = new UserTask
            {
                Id = ++UserTasks.IdCounter,
                Name = Messages.DefaultTaskName + " 1",
                Description = Messages.DefaultPeriodicDesc,
                TaskDate = DateTime.Now.AddMinutes(40),
                Period = 30000,
                CategoriesID = new List<int>()
            };
            UserTask t1 = new UserTask
            {
                Id = ++UserTasks.IdCounter,
                Name = Messages.DefaultTaskName + " 2",
                Description = Messages.DefaultTaskDesc,
                TaskDate = DateTime.Now.AddMinutes(50),
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
