using ParsingData_Tkachenko_.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingData_Tkachenko_
{
    public class Parser
    {

        public List<SomeFile> Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException("Please, enter some string");
            }

            List<SomeFile> someFiles = new List<SomeFile>();
            string[] inputSplit = input.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            for (var i = 0; i < inputSplit.Length; i++)
            {
                someFiles.Add(ParseFileString(inputSplit[i].Trim()));
            }

            return someFiles;
        }

        private static SomeFile ParseFileString(string input)
        {
            var fileDescription = input.Split(new char[] { ';' });
            var attributes = fileDescription.Skip(1).ToArray();
            var fileTypeNameAndSize = fileDescription[0];

            var typeSeparatorPosition = fileTypeNameAndSize.IndexOf(':');
            var fileType = GetFileType(fileTypeNameAndSize, typeSeparatorPosition);
            var nameAndSize = GetNameAndSize(fileTypeNameAndSize, typeSeparatorPosition);

            var sizeTokenPosition = nameAndSize.IndexOf('(');
            var nameAndExtension = GetNameWithExtension(nameAndSize, sizeTokenPosition);
            var extension = GetExtension(nameAndExtension);

            var name = nameAndExtension
                .Replace(extension, string.Empty)
                .TrimEnd('.')
                .Trim();

            string resultValid = ValidName(name);

            if (!string.IsNullOrEmpty(resultValid))
            {
                throw new Exception(resultValid);
            }

            var size = nameAndSize
                .Replace(nameAndExtension, string.Empty)
                .Trim('(', ')');

            return CreateSomeFile(fileType, name, size, extension, attributes);
        }

        private static string ValidName(string name)
        {
            char[] badSymbol = new[] { '~', '#','%', '&',
                                       '*', '{','}', '\\',
                                       ':', '<','>', '?',
                                       '/', '+','|', '\"'};

            foreach(char e in badSymbol)
            {
                if(name.Contains(e))
                {
                    return $"A file name can't contain any of the following characters:" +
                           $"~ # % & * : < > ? / + | \\ ' ";
                }          
            }              
                           
            if (name.Length > 210)
            {
                return "Name of the file exceeds allowed number of characters";
            }
           

            return string.Empty;
        }

        private static SomeFile CreateSomeFile(
            string fileType,
            string name,
            string size,
            string extension,
            string[] attributes)
        {
            switch (fileType.ToLowerInvariant())
            {
                case "text": return new TextFile(fileType, name, extension, size, attributes);
                case "movie": return new Movie(fileType, name, extension, size, attributes);
                case "image": return new Image(fileType, name, extension, size, attributes);
                default:
                    throw new NotImplementedException($"type {fileType} is not supported yet");
            }
        }

        private static string GetExtension(string name)
        {
            return name.Substring(name.LastIndexOf('.') + 1);
        }

        private static string GetNameWithExtension(string nameAndSize, int sizeTokenPosition)
        {
            return nameAndSize.Substring(0, sizeTokenPosition);
        }

        private static string GetNameAndSize(string fileTypeNameAndSize, int typeSeparatorPosition)
        {
            return fileTypeNameAndSize.Substring(typeSeparatorPosition + 1);
        }

        private static string GetFileType(string fileTypeNameAndSize, int typeSeparatorPosition)
        {
            return fileTypeNameAndSize.Substring(0, typeSeparatorPosition);
        }
    }
}
