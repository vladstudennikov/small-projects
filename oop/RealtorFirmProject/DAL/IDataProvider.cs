using System.Collections.Generic;

namespace DAL
{
    public interface IDataProvider<T>
    {
        void Write(T data, string link);
        List<T> Read(string link);
    }
}
