using Multiple.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;

namespace Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = "data/inputData.txt";
            var outputFile = "outputData.txt";
            var listData = FileService.GetDataFile(inputFile);
            var ListDataOutput = new List<string>();
            foreach (var i in listData)
            {
                var value = OperationService.IsMultipleOf3(i) ? "SI" : "NO";
                ListDataOutput.Add(value);
            }
            var textResult = String.Join(Environment.NewLine, ListDataOutput);
            FileService.SaveData(outputFile, textResult);
            
            Console.WriteLine($"La Ejecución ha terminado, el archivo de salida esta en:{Directory.GetCurrentDirectory()}");
            //Show notepad with result
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {

                Process process = new Process();
                process.StartInfo.FileName = "notepad.exe";
                process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
                process.StartInfo.Arguments = outputFile;
                process.Start();
            }

        }
    }
}
