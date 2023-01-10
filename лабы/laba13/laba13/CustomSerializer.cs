using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace laba13
{
    interface ISerialize
    {
        //void SOAPSerialize(object obj, string path);
        void XMLSerialize(Pastry obj, string path);
        void BinarySerialize(object obj, string path);
        void JSONSerialize(Pastry obj, string path);
        //Pastry SOAPDeserialize(string path);
        Pastry XMLDeserialize(string path);
        Pastry BinaryDeserialize(string path);
        Pastry JSONDeserialize(string path);
    }

    internal class CustomSerializer : ISerialize
    {
        public void BinarySerialize(object obj, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (Stream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
            }
        }
        public Pastry BinaryDeserialize(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Pastry obj;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                obj = (Pastry)formatter.Deserialize(fs);
            }
            return obj;
        }
        //public void SOAPSerialize(object obj, string path)
        //{
        //    SoapFormatter soapFormatter = new SoapFormatter();
        //    using (Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        soapFormatter.Serialize(fstream, obj);
        //    }
        //}
        //public Pastry SOAPDeserialize(string path)
        //{
        //    Pastry obj;
        //    SoapFormatter soapFormatter = new SoapFormatter();
        //    using (Stream fstream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
        //    {
        //        obj = (Pastry)soapFormatter.Deserialize(fstream);
        //    }
        //    return obj;
        //}
        public void XMLSerialize(Pastry obj, string path)
        {
            XmlSerializer xSer = new XmlSerializer(typeof(Pastry));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                xSer.Serialize(fs, obj);
            }
        }
        public Pastry XMLDeserialize(string path)
        {
            Pastry obj;
            XmlSerializer xSer = new XmlSerializer(typeof(Pastry));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                obj = xSer.Deserialize(fs) as Pastry;
            }
            return obj;
        }
        public void JSONSerialize(Pastry obj, string path)
        {
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Pastry));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                jsonSer.WriteObject(fs, obj);
            }
        }
        public Pastry JSONDeserialize(string path)
        {
            Pastry obj;
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Pastry));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                obj = (Pastry)jsonSer.ReadObject(fs);
            }
            return obj;
        }
    }
}
