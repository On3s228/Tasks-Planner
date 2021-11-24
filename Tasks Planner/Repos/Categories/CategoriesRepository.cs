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
        private readonly List<Category>? _categories;

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
                    Id = Category.IdCounter++,
                    Name = "Задания",
                    Description = "",
                    Tasks = new List<UserTask>()
                };
                UserTask t = new UserTask
                {
                    Id = UserTask.IdCounter++,
                    Name = "Напоминание",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum porta aliquam. Nam vel dolor at augue ornare euismod egestas ut enim. Fusce a maximus velit. Nulla ante augue, iaculis vel elit quis, eleifend dignissim ex. Sed a porttitor nulla, vitae volutpat nulla. Mauris felis massa, aliquam ut blandit at, dictum nec risus. Proin vel rutrum ante. Integer rutrum, quam ac tempus malesuada, turpis ex commodo tellus, in aliquet massa velit non dui. Donec vitae elementum lacus, in fermentum enim. Cras auctor, massa eu aliquet fringilla, eros massa laoreet quam, at efficitur metus est non nisi. Duis pellentesque erat in elit egestas, vel porttitor ipsum blandit. Nulla dui orci, accumsan vitae erat sed, rhoncus viverra eros. Praesent ut euismod ipsum. Donec sagittis diam at placerat pharetra. Vivamus eget quam nulla. Fusce tincidunt ultricies sapien.",
                    TaskDate = new DateTime(2021, 11, 23, 19, 30, 0)
                };
                t.Period = 30000;
                c.Tasks.Add(t);
                UserTask t1 = new UserTask
                {
                    Id = UserTask.IdCounter++,
                    Name = "Напоминание",
                    Description = "Тестовое напоминание",
                    TaskDate = new DateTime(2022, 11, 24)
                };
                c.Tasks.Add(t1);
                _categories.Add(c);
                Save();
            }
        }

        public void CreateCategory(Category item)
        {
            if (_categories != null)
            {
                _categories.Add(item);
                Save(); 
            }
        }

        public void CreateTask(int categoryId, UserTask task)
        {
            if(_categories != null)
            {
                _categories[categoryId].Tasks.Add(task);
                Save();
            }  
        }

        public void DeleteCategory(int id)
        {
            if (_categories != null)
            {
                if (!_categories[id].Tasks.Any())
                {
                    _categories.RemoveAt(id);
                    Save();
                }
                else Notifier.StringNotify("В категории есть напоминания. Сначала очистите категорию."); 
            }
        }

        public void DeleteTask(int categoryId, int taskId)
        {
            if (_categories != null)
            {
                _categories[categoryId].Tasks.RemoveAt(taskId);
                Save(); 
            }
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
            if (_categories != null)
            {
                _categories[id] = item;
                Save(); 
            }
        }

        public void UpdateTask(int categoryId, int taskId, UserTask task)
        {
            if (_categories != null)
            {
                _categories[categoryId].Tasks[taskId] = task;
                Save(); 
            }
        }
    }
}
