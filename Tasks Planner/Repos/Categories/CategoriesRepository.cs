using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tasks_Planner.Repos.Categories
{
    public class CategoriesRepository : IRepository<Category>
    {
        private readonly string _filePath;
        private readonly List<Category> _categories;

        public CategoriesRepository(string programPath)
        {
            _filePath = programPath + @"\userdata.json";
            
        }

        public void Create(Category item)
        {
            _categories.Add(item);
            Save();
        }

        public void Delete(int id)
        {
            _categories.RemoveAt(id);
            Save();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            return _categories[id];
        }

        public IEnumerable<Category> GetList()
        {
            return _categories;
        }

        public void Save()
        {
            
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }
    }
}
