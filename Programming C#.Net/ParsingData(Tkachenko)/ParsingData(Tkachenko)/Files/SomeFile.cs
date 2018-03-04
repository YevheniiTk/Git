using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingData_Tkachenko_.Files
{
    public abstract class SomeFile
    {
        public string Type { get; }
        protected string Name { get; }
        protected string Extension { get; }
        protected string Size { get; }

        protected readonly string[] SomeAttributes;

        public SomeFile(
            string type,
            string name,
            string extension,
            string size,
            string[] someAttributes)
        {
            this.Type = type;
            this.Name = name;
            this.Extension = extension;
            this.Size = size;
            this.SomeAttributes = someAttributes;
        }

        public abstract List<Tuple<string, string>> GetAttributesWithNames();

        public string Print()
        {
            string result = String.Empty;

            var allAtributes = new List<Tuple<string, string>>
            {
                Tuple.Create("Extension", this.Extension),
                Tuple.Create("Size", this.Size)
            };

            allAtributes.AddRange(this.GetAttributesWithNames());

            result += $"{this.Name}.{this.Extension}{Environment.NewLine}";

            foreach (var i in allAtributes)
            {
                result += $"\t\t{i.Item1} : {i.Item2}" + Environment.NewLine;
            }

            return result;
        }
    }
}
