using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace DAL
{
    public class BinaryDataProvider<T> : IDataProvider<T>
    {
        public List<T> Read(string link)
        { 
            using (FileStream fs = new FileStream(link, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                List<T> info = new List<T>();
                try 
                {
                    if (fs.Length != 0)
                    {
                        info = (List<T>)formatter.Deserialize(fs);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;

                }

                return info;

            }
        }

        public void Write(T data, string link)
        {
            using (FileStream fs = new FileStream(link, FileMode.OpenOrCreate))
            {
                BinaryFormatter formater = new BinaryFormatter();
                List<T> tmp = new List<T>();
                if (fs.Length != 0)
                {
                    tmp = (List<T>)formater.Deserialize(fs);
                    fs.SetLength(0);
                }
                tmp.Add(data);
                try 
                {
                    formater.Serialize(fs, tmp);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
