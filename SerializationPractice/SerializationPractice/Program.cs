using System;
using System.IO;
using System.Linq;

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
                Console.WriteLine(JSONFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
