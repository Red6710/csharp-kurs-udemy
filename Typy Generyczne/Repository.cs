using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace Typy_Generyczne
{
    public class Repository<T> where T : IEntity, new()
    {
        private List<T> data = new List<T> ();

        public void AddElement(T element)
        {
            if (element != null)
            {
                data.Add(element);
            }
        }
        public T GetElement(int index)
        { 
         if(index < data.Count)
            {
                return data[index];
            }
         else
            {
                return default;
            }
        }
        public T GetElementByID(int id)
        {
            var element = data.FirstOrDefault(e=>e.Id == id);
            return element;
        }

    }
    public class Repository<TKey, TValue> 
        where TKey : class
        where TValue : new()
    {
        private Dictionary<TKey,TValue> data = new Dictionary<TKey, TValue> ();

        public void AddElement(TKey key,TValue element)
        {
            if (element != null)
            {
                data.Add(key,element);
            }
        }
        public TValue GetElement(TKey key)
        {
            if (data.TryGetValue(key, out TValue result ))
            {
                return result;
            }
            else
            {
                return default;
            }
        }



    }
}
