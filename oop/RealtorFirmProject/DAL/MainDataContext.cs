using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace DAL
{
    public class MainDataContext<T> : IDataContext<T>
    {
        public string Link { get; private set; }
        public IDataProvider<T> DataProvider { get; set; }
        private List<T> _storedData;

        public MainDataContext(string con)
        {
            Link = con;
        }

        public List<T> GetData()
        {
            if (DataProvider != null)
            {
                return DataProvider.Read(Link);
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }

        public void SetData(T data)
        {
            if (DataProvider != null)
            {
                DataProvider.Write(data, Link);
                //_storedData = DataProvider.Read(Link);
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }

        public void clearFile(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
            }
        }
    }
}
