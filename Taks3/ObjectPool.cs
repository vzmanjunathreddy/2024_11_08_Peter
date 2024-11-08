using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class ObjectPool<T> where T : new()
    {
        private List<T> _instances;

        public ObjectPool()
        {
            _instances = new List<T>();
        }

        public T GetInstance()
        {
            if (_instances.Count == 0)
            {
                return new T();
            }
            var instance = _instances.First();
            _instances.Remove(instance);
            return instance;
        }

        public void Release(T instance)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("paramter can't be null");
            }
            _instances.Add(instance);
        }
    }
}
