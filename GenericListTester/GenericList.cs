using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListTester
{
    class GenericList <T>
    {
        private List<T> gList;

        public List<T> GList
        {
            get { return gList; }
        }

        public GenericList(List<T> list)
        {
            gList = new List<T>();
            gList = list;
        }

        public GenericList()
        {
            gList = new List<T>();
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= gList.Count)
            {
                return false;
            }

            gList.RemoveAt(index);
            Console.WriteLine("Item removed");
            return true;
        }

        public bool Remove(T item)
        {
            if(item == null || gList == null)
            {
                return false;
            }

            for (int i = 0; i < gList.Count; i++)
            {
                if(gList[i].Equals(item))
                {
                    gList.RemoveAt(i);
                    Console.WriteLine("Item removed");
                    return true;
                }
            }

            return false;
        }

        public T Get(int index)
        {
            if (gList == null)
            {
                return default(T);
            }
            else if (index < 0 || index >= gList.Count)
            {
                return default(T);
            }

            return gList[index];
        }

        public bool Add(T item)
        {
            if(gList == null)
            {
                return false;
            }

            gList.Add(item);
            return true;
        }

        public bool PrintList()
        {
            if(gList == null)
            {
                return false;
            }

            Console.WriteLine(this.ToString());
            return true;
        }

        public override string ToString()
        {
            if(gList == null)
            {
                return "";
            }

            string str = $"List of {typeof(T)} with {gList.Count} items:\n";

            foreach (T item in gList)
            {
                str += item.ToString() + "\n";
            }
            return str;
        }
    }
}
