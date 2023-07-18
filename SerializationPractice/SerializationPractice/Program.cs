using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;

namespace SerializationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path to folder");
            var folderPath = @"..\..\..\TestingData\d\"; ///Console.ReadLine();
            try
            {
                var JSONFilePath = Reader.GetJSONFilePath(folderPath);
                using (var file = new StreamReader(JSONFilePath))
                {
                    var text = file.ReadToEnd();
                    var squad = JsonSerializer.Deserialize<Squad>(text);

                    var XMLFilePath = folderPath + @"\Squad.xml";

                    if (File.Exists(XMLFilePath))
                    {
                        File.Delete(XMLFilePath);
                        Console.WriteLine("Файл Squad.xml будет перезаписан.");
                    }

                    using (var xmlFile = new FileStream(folderPath + @"\Squad.xml", FileMode.CreateNew))
                    {
                        new XmlSerializer(typeof(Squad)).Serialize(xmlFile, squad);
                        Console.WriteLine("Файл Squad.xml записан.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
