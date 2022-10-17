using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DAL
{
    public class BinaryDataProvider<T> : IDataProvider<T>
    {
        public T Read(string connection)
        {
            T data;
            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter1 = new BinaryFormatter();
                try
                {
                    data = (T)formatter1.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return data;
        }

        public void Write(T data, string connection)
        {
            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter1 = new BinaryFormatter();
                try
                {
                    formatter1.Serialize(fs, data);
                }
                catch (Exception ex) 
                {
                    throw ex;
                }
            }
        }
    }
}
