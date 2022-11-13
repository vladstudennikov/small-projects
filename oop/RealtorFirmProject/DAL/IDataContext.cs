using System.Collections.Generic;

namespace DAL
{
    interface IDataContext<T>
    {
        string Link { get; }
        IDataProvider<T> DataProvider { get; set; }
        List<T> GetData();
        void SetData(T data);
    }
}
