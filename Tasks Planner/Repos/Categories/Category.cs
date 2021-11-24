using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks_Planner.Repos.Tasks;

namespace Tasks_Planner.Repos.Categories
{
    public class Category : IEquatable<Category?>
    {
        public static int IdCounter = 1;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category() { }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Category);
        }

        public bool Equals(Category? other)
        {
            return other != null &&
                   Name == other.Name &&
                   Description == other.Description;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Description);
        }

        public static bool operator ==(Category? left, Category? right)
        {
            return EqualityComparer<Category>.Default.Equals(left, right);
        }

        public static bool operator !=(Category? left, Category? right)
        {
            return !(left == right);
        }
    }
}
