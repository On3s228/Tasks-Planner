using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos.Categories
{
    public class CategoriesRepository : IRepository<Category>
    {
        private readonly string _filePath;
        private readonly List<Category>? _categories;

        public CategoriesRepository(string programPath)
        {
            _filePath = programPath + @"\Categories.json";
            if (File.Exists(_filePath))
            {
                _categories = JSerializer<List<Category>>.Deserialize(_filePath);
            } 
            else
            {
                _categories = new List<Category>();
                Category c = new Category
                {
                    Id = Category.IdCounter++,
                    Name = "Задания",
                    Description = "",
                };
                _categories.Add(c);
                Save();
            }
        }

        public void Create(Category item)
        {
            if (_categories != null)
            {
                _categories.Add(item);
                Save();
            }
            else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public void Delete(int id)
        {
            if (_categories != null)
            {
                _categories.RemoveAt(id);
                Save();
            }
            else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            if (_categories != null)
            {
                return _categories[id];
            }
            else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public IEnumerable<Category> GetList()
        {
            if (_categories != null)
            {
                return _categories;
            }
            else throw new ArgumentException("Непредвиденная ошибка!");
        }

        public void Save()
        {
            JSerializer<List<Category>?>.Serialize(_categories, _filePath);
        }

        public void Update(int id, Category item)
        {
            if (_categories != null)
            {
                _categories[id] = item;
                Save();
            }
            else throw new ArgumentException("Непредвиденная ошибка!");
        }
    }
}
