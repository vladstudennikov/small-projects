using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDataProvider<T>
    {
        void Write(T data, string connection);
        T Read(string connection);
    }
}
