using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.CommonFiles
{
    public class ListManager<T> : IListManager<T>
    {
        // Fields
        private List<T> m_List;

        /// <summary>
        /// Gets the number of elements in the list.
        /// </summary>
        public int Count
        {
            get { return m_List.Count; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListManager{T}"/> class with an empty list.
        /// </summary>
        public ListManager()
        {
            m_List = new List<T>();
        }

        /// <summary>
        /// Adds a new item of type <typeparamref name="T"/> to the list.
        /// </summary>
        public bool Add(T type)
        {
            try
            {
                m_List.Add(type);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Changes the item at the specified index to a new value.
        /// </summary>
        public bool ChangeAt(T type, int index)
        {
            if (CheckIndex(index))
            {
                m_List[index] = type;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if the specified index is valid for the current list.
        /// </summary>
        public bool CheckIndex(int index)
        {
            return index >= 0 && index < m_List.Count;
        }

        /// <summary>
        /// Deletes all items in the list.
        /// </summary>
        public void DeleteAll()
        {
            m_List.Clear();
        }

        /// <summary>
        /// Deletes the item at the specified index.
        /// </summary>
        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                m_List.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the item at the specified index.
        /// </summary>
        public T GetAt(int index)
        {
            if (CheckIndex(index))
            {
                return m_List[index];
            }
            throw new ArgumentOutOfRangeException("Index is out of range.");
        }

        /// <summary>
        /// Converts the list of items to an array of strings, using each item's <see cref="object.ToString"/> method.
        /// </summary>
        public string[] ToStringArray()
        {
            List<string> stringList = new List<string>();
            foreach (var item in m_List)
            {
                stringList.Add(item.ToString());
            }
            return stringList.ToArray();
        }

        /// <summary>
        /// Converts the list of items to a list of strings, using each item's <see cref="object.ToString"/> method.
        /// </summary>
        public List<string> ToStringList()
        {
            List<string> stringList = new List<string>();
            foreach (var item in m_List)
            {
                stringList.Add(item.ToString());
            }
            return stringList;
        }
    }
}
