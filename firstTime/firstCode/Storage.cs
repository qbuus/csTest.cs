namespace Project
{
    public class Storage<T> where T:IStorage
    {
        private List<T> data = new List<T>();

        public void add(T item)
        {
            if (item != null) 
            {
                data.Add(item);
            }
        }

        public T findById (int id)
        {
            var IdEl = data.FirstOrDefault(c => c.Id == id);
            return IdEl;
        }

        public T rtSpecificElement(int index)
        {
            if (index < data.Count) 
            {
                return data[index];
            } else 
            {
                return default(T);
            }
        }
    }

    public class Storage<TK, TV>
    {
        private Dictionary<TK, TV> dictionary = new Dictionary<TK, TV>();

        public void add(TK item, TV value)
        {
            if (item != null && value != null) 
            {
                dictionary.Add(item, value);
            }
        }

        public TV rtSpecificElement(TK key)
        {
            if (dictionary.TryGetValue(key, out TV result)) 
            {
                return result;
            } else 
            {
                return default(TV);
            }
        }
    }
}