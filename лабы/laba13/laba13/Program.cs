using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml;
using System;

namespace laba13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomSerializer serializer = new CustomSerializer();
            Pastry obj = new Pastry() { Price = 25, Weight = 700, Factory = "Комунарка" };
            string path = "C:\\Users\\USER\\Desktop\\labs\\3сем\\ооп\\laba13";
            // сериализация в двоичный файл
            serializer.BinarySerialize(obj, path + "\\binary.dat");
            // десериализация двоичного файла
            Pastry objBin = serializer.BinaryDeserialize(path + "\\binary.dat");

            // сериализация в SOAP
            //serializer.SOAPSerialize(obj, path + "\\SOAP.dat");
            // десериализация SOAP
            //Hanger objSOAP = serializer.SOAPDeserialize(path + "\\SOAP.dat");

            // сериализация xml
            serializer.XMLSerialize(obj, path + "\\xml.xml");
            // десериализация xml
            Pastry objXML = serializer.XMLDeserialize(path + "\\xml.xml");

            // сериализация JSON
            serializer.JSONSerialize(obj, path + "\\JSON.json");
            // десериализация JSON
            Pastry objJSON = serializer.JSONDeserialize(path + "\\JSON.json");

            // сериализация коллекции
            Pastry obj2 = new Pastry() { Price = 10, Weight = 1000, Factory = "AAA" };
            Pastry obj3 = new Pastry() { Price = 20, Weight = 2000, Factory = "BBB" };
            List<Pastry> list = new List<Pastry>();
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj);
            XmlSerializer serializer2 = new XmlSerializer(typeof(List<Pastry>));
            using (Stream fs = new FileStream("Collection.xml", FileMode.OpenOrCreate))
            {
                serializer2.Serialize(fs, list);
            }
            List<Pastry> list2 = new List<Pastry>();
            using (FileStream fs = new FileStream("Collection.xml", FileMode.OpenOrCreate))
            {
                list2 = (List<Pastry>)serializer2.Deserialize(fs);
            }

            // XPath
            XmlDocument document = new XmlDocument();
            document.Load("Collection.xml");
            XmlElement root = document.DocumentElement;
            Console.WriteLine("Все дочерние элементы:");
            XmlNodeList listn = root.SelectNodes("*");
            foreach (XmlNode a in listn)
            {
                Console.WriteLine(a.OuterXml);
            }
            Console.WriteLine("Все теги Factory");
            XmlNodeList lisnName = root.SelectNodes("//Pastry/Factory");
            foreach (XmlNode a in lisnName)
            {
                Console.WriteLine(a.InnerText);
            }

            // linq to xml
            XDocument xdoc = new XDocument();
            XElement tom = new XElement("person");
            XAttribute tomNameAttr = new XAttribute("name", "Tom");
            XElement tomCompanyElem = new XElement("company", "Microsoft");
            XElement tomAgeElem = new XElement("age", 37);
            tom.Add(tomNameAttr);
            tom.Add(tomCompanyElem);
            tom.Add(tomAgeElem);

            XElement bob = new XElement("person");
            XAttribute bobNameAttr = new XAttribute("name", "Bob");
            XElement bobCompanyElem = new XElement("company", "Google");
            XElement bobAgeElem = new XElement("age", 41);
            bob.Add(bobNameAttr);
            bob.Add(bobCompanyElem);
            bob.Add(bobAgeElem);
            XElement people = new XElement("people");
            people.Add(tom);
            people.Add(bob);
            xdoc.Add(people);
            xdoc.Save("people.xml");

            xdoc = XDocument.Load("people.xml");
            people = xdoc.Element("people");
            if (people is not null)
            {
                foreach (XElement person in people.Elements("person"))
                {

                    XAttribute? name = person.Attribute("name");
                    XElement? company = person.Element("company");
                    XElement? age = person.Element("age");

                    Console.WriteLine($"Person: {name?.Value}");
                    Console.WriteLine($"Company: {company?.Value}");
                    Console.WriteLine($"Age: {age?.Value}");

                    Console.WriteLine();
                }
            }
            var bob2 = people.Elements("person").FirstOrDefault(p => p.Attribute("name")?.Value == "Bob");
            if (bob2 != null)
            {
                bob2.Remove();
                xdoc.Save("people.xml");
            }
        }
    }
}