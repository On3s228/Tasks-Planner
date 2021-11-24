using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos.Categories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly string _filePath;
        private readonly List<Category> _categories;

        public CategoriesRepository(string programPath)
        {
            _filePath = programPath + @"\userdata.json";
            if (File.Exists(_filePath))
            {
                _categories = JSerializer<List<Category>>.Deserialize(_filePath);
            } else
            {
                _categories = new List<Category>();
                Category c = new Category
                {
                    Name = "Задания",
                    Description = "",
                    Tasks = new List<Tasks.UserTask>()
                };
            }
        }

        public void CreateCategory(Category item)
        {
            _categories.Add(item);
            Save();
        }

        public void CreateTask(int categoryId, UserTask task)
        {
            _categories[categoryId].Tasks.Add(task);
            Save();
        }

        public void DeleteCategory(int id)
        {
            if (!_categories[id].Tasks.Any())
            {
                _categories.RemoveAt(id);
                Save();
            }
            else Notifier.StringNotify("В категории есть напоминания. Сначала очистите категорию.");
        }

        public void DeleteTask(int categoryId, int taskId)
        {
            _categories[categoryId].Tasks.RemoveAt(taskId);
            Save();
        }

        public IEnumerable<Category> GetCategoriesList()
        {
            return _categories;
        }

        public Category GetCategory(int id)
        {
            return _categories[id];
        }

        public UserTask GetTask(int categoryId, int taskId)
        {
            return _categories[categoryId].Tasks[taskId];
        }

        public IEnumerable<UserTask> GetTasksList(int categoryId)
        {
            return _categories[categoryId].Tasks;
        }

        public void Save()
        {
            JSerializer<List<Category>>.Serialize(_categories, _filePath);
        }

        public void UpdateCategory(int id, Category item)
        {
            _categories[id] = item;
            Save();
        }

        public void UpdateTask(int categoryId, int taskId, UserTask task)
        {
            _categories[categoryId].Tasks[taskId] = task;
            Save();
        }
    }
}
