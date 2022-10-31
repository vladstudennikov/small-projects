using System;
using System.IO;
using System.Xml.Serialization;

namespace DAL
{
    public class XMLDataProvider<T> : IDataProvider<T>
    {
        public T Read(string link)
        {
            T data;
            using (FileStream fs = new FileStream(link, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(T));
                try
                {
                    data = (T)formatter.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return data;
        }

        public void Write(T data, string link)
        {
            using (FileStream fs = new FileStream(link, FileMode.OpenOrCreate))
            {
                XmlSerializer formatter = new XmlSerializer(data.GetType());
                try
                {
                    formatter.Serialize(fs, data);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
