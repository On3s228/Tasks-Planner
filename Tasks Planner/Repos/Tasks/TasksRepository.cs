using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Categories;

namespace Tasks_Planner.Repos.Tasks
{
    public class TasksRepository : IRepository<UserTask>
    {
        private readonly string _filePath;
        private readonly List<UserTask>? _tasks;
        private readonly CategoriesRepository _categories;

        public TasksRepository(string programPath, CategoriesRepository categoriesRepository)
        {
            _filePath = programPath + @"\Tasks.json";
            _categories = categoriesRepository;
            if (File.Exists(_filePath))
            {
                _tasks = JSerializer<List<UserTask>>.Deserialize(_filePath);
            } else
            {
                _tasks = new List<UserTask>();
                Category c = _categories.GetByID(0);
                UserTask t = new UserTask
                {
                    Id = UserTask.IdCounter++,
                    Name = "Напоминание",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam interdum porta aliquam. Nam vel dolor at augue ornare euismod egestas ut enim. Fusce a maximus velit. Nulla ante augue, iaculis vel elit quis, eleifend dignissim ex. Sed a porttitor nulla, vitae volutpat nulla. Mauris felis massa, aliquam ut blandit at, dictum nec risus. Proin vel rutrum ante. Integer rutrum, quam ac tempus malesuada, turpis ex commodo tellus, in aliquet massa velit non dui. Donec vitae elementum lacus, in fermentum enim. Cras auctor, massa eu aliquet fringilla, eros massa laoreet quam, at efficitur metus est non nisi. Duis pellentesque erat in elit egestas, vel porttitor ipsum blandit. Nulla dui orci, accumsan vitae erat sed, rhoncus viverra eros. Praesent ut euismod ipsum. Donec sagittis diam at placerat pharetra. Vivamus eget quam nulla. Fusce tincidunt ultricies sapien.",
                    TaskDate = new DateTime(2021, 11, 23, 19, 30, 0),
                    Categories = new List<Category>()
                };
                t.Period = 30000;
                UserTask t1 = new UserTask
                {
                    Id = UserTask.IdCounter++,
                    Name = "Напоминание",
                    Description = "Тестовое напоминание",
                    TaskDate = new DateTime(2022, 11, 24),
                    Categories = new List<Category>()
                };
                t.Categories.Add(c);
                t1.Categories.Add(c);
                _tasks.Add(t);
                _tasks.Add(t1);

                Save();
            }
        }

        public void Create(UserTask item)
        {
            if (_tasks != null)
            {
                _tasks.Add(item);
            } else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public void Delete(int id)
        {
            if (_tasks != null)
            {
                _tasks.RemoveAt(id);
                Save();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public UserTask GetByID(int id)
        {
            if (_tasks != null)
            {
                return _tasks[id];
            }
            else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public IEnumerable<UserTask> GetList()
        {
            if (_tasks != null)
            {
                return _tasks; 
            } else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public void Save()
        {
            JSerializer<List<UserTask>?>.Serialize(_tasks, _filePath);
        }

        public void Update(int id, UserTask item)
        {
            if (_tasks != null)
            {
                _tasks[id] = item;
                Save(); 
            }
        }
    }
}
