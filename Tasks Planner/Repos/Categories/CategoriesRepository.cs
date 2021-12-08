using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Tasks_Planner.Properties;
using Tasks_Planner.Repos.Tasks;
using Tasks_Planner.Tools;

namespace Tasks_Planner.Repos.Categories
{
    public class CategoriesRepository : IRepository<Category>
    {
        private readonly string _filePath;
        private readonly Categories? _categories;

        public CategoriesRepository(string programPath)
        {
            _filePath = programPath + @"\Categories.json";
            if (File.Exists(_filePath))
            {
                _categories = JSerializer<Categories>.Deserialize(_filePath);
            } 
            else
            {
                _categories = DefaultRepositories.GetDefaultCategories();
                Save();
            }
            _categories.CategoriesList.CollectionChanged += (sender, args) =>
            {
                Events.CategoriesListChanged();
            };
        }

        public bool Create(Category item)
        {
            if (_categories?.CategoriesList != null)
            {
                if (!_categories.CategoriesList.Contains(item))
                {
                    _categories.CategoriesList?.Add(item);
                    Save();
                    return true;
                }
                else
                    return false;
            }
            else throw new ArgumentException(Messages.Error);
        }

        public void Delete(int id)
        {
            if (_categories != null)
            {
                _categories.CategoriesList?.RemoveAt(id);
                Save();
            }
            else throw new ArgumentException(Messages.Error);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Category GetByID(int id)
        {
            if (_categories?.CategoriesList != null)
            {
                return _categories.CategoriesList[id];
            }
            else throw new ArgumentException(Messages.Error);
        }

        public IEnumerable<Category> GetList()
        {
            if (_categories?.CategoriesList != null)
            {
                return _categories.CategoriesList;
            }
            else throw new ArgumentException(Messages.Error);
        }

        public void Save()
        {
            JSerializer<Categories?>.Serialize(_categories, _filePath);
        }

        public bool Update(Category item)
        {
            if (_categories?.CategoriesList != null)
            {
                int id = _categories.CategoriesList.ToList().FindIndex(category => category.Id == item.Id);
                _categories.CategoriesList[id] = item;
                Save();
                return true;
            }
            else throw new ArgumentException(Messages.Error);
        }
    }
}
