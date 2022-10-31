using System;

namespace DAL
{
    public class MainDataContext<T> : IDataContext<T>
    {
        public string Link { get; private set; }
        public IDataProvider<T> DataProvider { get; set; }
        private T _storedData;

        public MainDataContext(string con)
        {
            Link = con;
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
                        _storedData = DataProvider.Read(Link);
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
                DataProvider.Write(data, Link);
                _storedData = data;
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }
    }
}
