using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParsingData_Tkachenko_.Files;

namespace ParsingData_Tkachenko_
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"Text: file.txt(6B);Some string content
                             Image:img.bmp(19mb);1920x1080
                             Text:data.txt(12B);Some another code
                             Movie:logan.2017.mkv(19GB);1920x1080;2h12m";

            var parser = new Parser();
            var listObjects = parser.Parse(input);
            var printedFiles = PrintFiles(listObjects);

            Console.Write(printedFiles);
            Console.ReadKey();
        }

        private static string PrintFiles(List<SomeFile> inputList)
        {
            string resultString = string.Empty;
            var fileGroups = from file in inputList
                             group file by file.Type;

            foreach (IGrouping<string, SomeFile> curentType in fileGroups)
            {
                resultString += curentType.Key + Environment.NewLine; 

                foreach (var curentFile in curentType)
                {
                    resultString += "\t" + curentFile.Print() + Environment.NewLine;
                }
            }
            return resultString;
        }
    }
}
