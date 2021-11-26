using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tasks_Planner.Repos;

namespace Tasks_Planner
{
    public static class JSerializer<T>
    {
        private static JsonSerializer serializer = new JsonSerializer();
        public static void Serialize(T item, string filePath)
        {
            serializer.Formatting = Formatting.Indented;
            using (StreamWriter sw = new StreamWriter(filePath))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, item);
            }
        }
        public static T? Deserialize(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                T? result = serializer.Deserialize<T>(reader);
                return result;
            }
        }
    }
}
