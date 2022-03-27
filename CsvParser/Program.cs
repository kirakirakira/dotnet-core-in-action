using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace CsvParser
{
    class Program
    {
        static void Main(string[] args)
        {
            // var filePath = @"Marvel.csv";
            var stream = typeof(Program).GetTypeInfo().Assembly.GetManifestResourceStream("CsvParser.Marvel.csv");
            var sr = new StreamReader(stream);
            var csvReader = new CsvReader(sr);
            foreach (var line in csvReader.Lines)
            {
                Console.WriteLine(line.First(p => p.Key == "Title").Value);
            }
        }
    }
}
