using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos.Categories;
using Tasks_Planner.Tools;

namespace Tasks_Planner.Repos.Tasks
{
    public class TasksRepository : IRepository<UserTask>
    {
        private readonly string _filePath;
        private readonly UserTasks? _tasks;
        private readonly IRepository<Category> _categories;

        public TasksRepository(string programPath, IRepository<Category> categoriesRepository)
        {
            _filePath = programPath + @"\Tasks.json";
            _categories = categoriesRepository;
            if (File.Exists(_filePath))
            {
                _tasks = JSerializer<UserTasks>.Deserialize(_filePath);
            } else
            {
                _tasks = DefaultRepositories.GetDefaultTasks(_categories);

                Save();
            }
            _tasks.TasksList.CollectionChanged += (sender, args) =>
            {
                Events.TasksListChanged();
            };
        }

        public bool Create(UserTask item)
        {
            if (_tasks?.TasksList != null)
            {
                if (!_tasks.TasksList.Contains(item))
                {
                    _tasks.TasksList?.Add(item);
                    Save();
                    return true;
                } else 
                    return false;

            } else throw new ArgumentException(Messages.Error);
        }

        public void Delete(int id)
        {
            if (_tasks != null)
            {
                _tasks.TasksList?.RemoveAt(id);
                Save();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public UserTask GetByID(int id)
        {
            if (_tasks != null && _tasks.TasksList != null)
            {
                return _tasks.TasksList[id];
            }
            else throw new ArgumentException(Messages.Error);
        }

        public IEnumerable<UserTask> GetList()
        {
            if (_tasks != null && _tasks.TasksList != null)
            {
                return _tasks.TasksList; 
            } else throw new ArgumentException(Messages.Error);
        }

        public void Save()
        {
            JSerializer<UserTasks?>.Serialize(_tasks, _filePath);
        }

        public bool Update(int id, UserTask item)
        {
            if (_tasks != null && _tasks.TasksList != null)
            {
                if (!_tasks.TasksList.Contains(item))
                {
                    _tasks.TasksList[id] = item;
                    Save();
                    return true;
                }
                else
                    return false;
            }
            else throw new ArgumentException();
        }
    }
}
