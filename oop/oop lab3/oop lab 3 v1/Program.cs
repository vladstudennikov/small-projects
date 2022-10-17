using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace oop_lab_3_v1
{
    class Program
    {
        public static void BinarySerialization<T>(string path, ref T[] arr)
        {
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter1.Serialize(fs, arr);
            }
        }

        public static void BinaryDeserialization<T>(string path, ref T[] arr)
        {
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                arr = (T[])formatter1.Deserialize(fs);
            }
        }

        public static void JsonSerialization<T>(string dirPath, string name, ref T[] arr)
        {
            string[] paths = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string tmpString = dirPath + name + (i + 1).ToString() + ".json";
                paths[i] = tmpString;
            }

            DataContractJsonSerializer formatter2 = new DataContractJsonSerializer(typeof(T));

            for (int i = 0; i < arr.Length; i++)
            {
                using (FileStream fs = new FileStream(paths[i], FileMode.OpenOrCreate))
                {
                    formatter2.WriteObject(fs, arr[i]);
                }
            }
        }

        public static void JsonDeserialization<T>(string dirPath, string name, ref T[] arr)
        {
            string[] paths = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                string tmpString = dirPath + name + (i + 1).ToString() + ".json";
                paths[i] = tmpString;
            }

            DataContractJsonSerializer formatter2 = new DataContractJsonSerializer(typeof(T));

            for (int i = 0; i < arr.Length; i++)
            {
                using (FileStream fs = new FileStream(paths[i], FileMode.OpenOrCreate))
                {
                    arr[i] = (T)formatter2.ReadObject(fs);
                }
            }
        }

        public static void XmlSerialization<T>(string path, ref T[] arr)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T[]));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, arr);
            }
        }

        public static void XmlDeserialization<T>(string path, ref T[] arr)
        {
            XmlSerializer xml = new XmlSerializer(typeof(T[]));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                arr = (T[])xml.Deserialize(fs);
            }
        }

        public static void printArray<T>(ref T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Deserialized element #{i + 1}: " + arr[i].ToString());
            }
        }

        static void Main(string[] args)
        {
            string[] valuesArray = new string[5] { "string1", "string2", "string3", "string4", "string5" };
            String[] array1 = new String[5];

            //filling array1 with new Strings
            for (int i = 0; i < 5; i++)
            {
                array1[i] = new String(valuesArray[i]);
            }

            //binary serialization
            Console.WriteLine("========================================");
            Console.WriteLine("Binary serialization:\n");

            string pathBin = @"C:\lab1\data.dat";
            String[] binSerializationResult = new String[array1.Length];

            BinarySerialization<String>(pathBin, ref array1);
            Console.WriteLine("Objects were serialized\n");
            BinaryDeserialization<String>(pathBin, ref binSerializationResult);

            printArray<String>(ref binSerializationResult);

            Console.WriteLine("========================================");

            //JSON
            Console.WriteLine("JSON serialization:\n");

            string dirPath = @"C:\lab1\";
            string name = "js";
            String[] JsonSerializationResult = new String[array1.Length];

            JsonSerialization<String>(dirPath, name, ref array1);
            Console.WriteLine("Objects were serialized\n");
            JsonDeserialization<String>(dirPath, name, ref JsonSerializationResult);

            printArray<String>(ref JsonSerializationResult);

            //XML
            Console.WriteLine(" ========================================");
            Console.WriteLine("XML serialization:");

            String[] XmlSerializationResult = new String[array1.Length];
            string pathXml = @"C:\lab1\xml_serialization.xml";

            XmlSerialization<String>(pathXml, ref array1);
            Console.WriteLine("Objects were serialized");
            XmlDeserialization<String>(pathXml, ref XmlSerializationResult);

            printArray<String>(ref XmlSerializationResult);

            Console.WriteLine("========================================");

            
        }
    }
}
