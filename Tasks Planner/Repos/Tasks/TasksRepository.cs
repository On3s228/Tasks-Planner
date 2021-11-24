using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_Planner.Repos.Tasks
{
    public class TasksRepository : IRepository<UserTask>
    {
        private readonly List<UserTask> _tasks;
        public TasksRepository()
        {

        }
        public void Create(UserTask item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public UserTask GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserTask> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(UserTask item)
        {
            throw new NotImplementedException();
        }
    }
}
