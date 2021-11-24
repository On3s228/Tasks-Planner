using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos.Categories
{
    public interface ICategoriesRepository
    {
        IEnumerable<Category> GetCategoriesList();
        Category GetCategory(int id);
        void CreateCategory(Category item);
        void UpdateCategory(int id, Category item);
        void DeleteCategory(int id);

        IEnumerable<UserTask> GetTasksList(int categoryId);
        UserTask GetTask(int categoryId, int taskId);
        void CreateTask(int categoryId, UserTask task);
        void UpdateTask(int categoryId, int taskId, UserTask task);
        void DeleteTask(int categoryId, int taskId);
        void Save();
    }
}
