using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Multiple.Service
{
    public class FileService
    {
        public static List<string> GetDataFile(string path)
        {
            IEnumerable<string> lines = File.ReadLines(path);
            return lines.ToList();
        }

        public static void SaveData(string path, string txt)
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write(txt);
            }
        }
    }
}
