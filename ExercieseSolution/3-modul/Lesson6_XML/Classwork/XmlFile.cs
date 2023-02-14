using System.Xml;
using System.Xml.Serialization;

namespace _3_modul.Lesson6_XML.Classwork
{
    public class XmlFile
    {
        public static void Run()
        {
            string xml1 = @"..\..\..\Lesson6_XML\Classwork\xml1.xml";

            Console.Write("name: ");
            string? name = Console.ReadLine();

            Console.Write("age: ");
            int age = int.Parse(Console.ReadLine());

            Person person = new Person
            {
                Age = age,
                Name = name
            };

            
            XmlSerializer serializer = new XmlSerializer(typeof(Person));

            using(StreamWriter writer = File.AppendText(xml1))
            {
                serializer.Serialize(writer, person);
            }
            Console.WriteLine("Successfully written");

            Person? person1;

            using (StreamReader reader = new StreamReader(xml1))
            {
                person1 = serializer.Deserialize(reader) as Person;
            }

            Console.WriteLine($"Id: {person1.Id}\nname: {person1.Name}\nage: {person1.Age}");

        }
    }
}
