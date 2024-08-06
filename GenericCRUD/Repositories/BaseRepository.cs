using System.Text.Json;

namespace GenericCRUD.Repositories
{
    internal class BaseRepository<TKey, TValue> : IBaseRepository<TKey, TValue>
    {
        public BaseRepository()
        {
            if (!File.Exists(GetFullPath()))
            {
                File.WriteAllText(GetFullPath(), "[]");
            }
        }

        string folderPath = "C:\\Users\\sardo\\OneDrive\\Рабочий стол\\Projects\\C#Tutorial\\GenericCRUD\\Database";
        public TValue Delete(TKey key)
        {
            var values = GetAll();

            var item = GetById(key);
            values.Remove(item);

            File.WriteAllText(GetFullPath(), JsonSerializer.Serialize(values));

            return item;
        }

        public List<TValue> Filter(Func<TValue, bool> predicate)
        {
            var values = GetAll();
            var filtered = values.Where(predicate);

            return filtered.ToList();
        }

        public List<TValue> GetAll()
        {
            var path = GetFullPath();
            var jsonContent = File.ReadAllText(path);

            return JsonSerializer.Deserialize<List<TValue>>(jsonContent);
        }

        public TValue GetById(TKey key)
        {
            var values = GetAll();
            var propertyId = typeof(TValue).GetProperty("Id");
            var item = values.Find(x => propertyId.GetValue(x) == (object)key);
            return item;
        }

        public TValue Insert(TValue item)
        {
            var path = GetFullPath();
            var values = GetAll();
            values.Add(item);
            File.WriteAllText(path, JsonSerializer.Serialize(values));

            return item;
        }

        public TValue Update(TKey key, TValue item)
        {
            var existed = GetById(key);
            var values = GetAll();
            existed = item;

            return existed;
        }

        string GetFullPath()
        {
            return folderPath + "\\" + typeof(TValue).Name + ".txt";
        }
    }
}