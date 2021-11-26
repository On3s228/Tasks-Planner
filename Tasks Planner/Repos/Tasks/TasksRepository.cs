using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Properties;
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
                _tasks = DefaultRepositories.GetDefaultTasks(_categories);

                Save();
            }
        }

        public void Create(UserTask item)
        {
            if (_tasks != null)
            {
                _tasks.Add(item);
            } else throw new ArgumentException(Messages.Error);
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
            else throw new ArgumentException(Messages.Error);
        }

        public IEnumerable<UserTask> GetList()
        {
            if (_tasks != null)
            {
                return _tasks; 
            } else throw new ArgumentException(Messages.Error);
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
