using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public class Enviroment : IEnviroment
    {
        private Dictionary<string, object> collection;

        public Enviroment()
        {
            this.collection = new Dictionary<string, object>();    
        }

        public object Get(string key)
        {
            return this.collection[key];
        }

        public T Get<T>()
        {
            return (T)this.collection[typeof(T).FullName];
        }

        public void Set(string key, object value)
        {
            this.collection[key] = value;
        }

        public void Set<T>(T model)
        {
            this.collection[typeof(T).Name] = model;
        }

        public object this[string key]
        {
            set
            {
                this.Set(key, value);
            }
            get
            {
                return this.Get(key);
            }
        }
    }
}
