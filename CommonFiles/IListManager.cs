using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4.CommonFiles
{
    public interface IListManager<T>
    {
        int Count { get; }
        bool Add(T type);
        bool ChangeAt(T type, int index);
        bool CheckIndex(int index);
        void DeleteAll();
        bool DeleteAt(int index);
        T GetAt(int index);
        string[] ToStringArray();
        List<string> ToStringList();
    }
}
