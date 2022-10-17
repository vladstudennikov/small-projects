using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataContext1<T> : IDataContext<T>
    {
        public string ConnectionString { get; private set; }
        public IDataProvider<T> DataProvider { get; set; }
        private T _storedData;

        public DataContext1(string con)
        {
            ConnectionString = con;
        }

        public T GetData()
        {
            if (DataProvider != null)
            {
                if (_storedData != null)
                    return _storedData;
                else
                {
                    try
                    {
                        _storedData = DataProvider.Read(ConnectionString);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    return _storedData;
                }
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }

        public void SetData(T data)
        {
            if (DataProvider != null)
            {
                DataProvider.Write(data, ConnectionString);
                _storedData = data;
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }
    }
}

