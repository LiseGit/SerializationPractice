using SerializationPractice.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationPractice
{
    public static class Reader
    {
        public static string GetJSONFilePath(string folderPath)
        {
            var folderFilesList = Directory.GetFiles(folderPath);
            if (folderFilesList.Length == 0)
            {
                throw new NoFilesException("В папке нет файлов.");
                return String.Empty;
            }
            if (!folderFilesList.Any(x=> x.Contains(".json")))
            {
                throw new NoJSONFileException("В папке нет JSON файлов.");
                return String.Empty;
            }
            if (folderFilesList.Where(x => x.Contains(".json")).ToArray().Length>1)
            {
                throw new NoJSONFileException("В папке неcколько JSON файлов.");
                return String.Empty;
            }
            return folderFilesList.First(x => x.Contains(".json"));
        }
    }
}
