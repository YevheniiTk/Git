using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingData_Tkachenko_.Files
{
    public class TextFile : SomeFile
    {
        public string Content { get; }

        public TextFile(
            string type,
            string name, 
            string extension, 
            string size, 
            string[] someAttributes) 
            : base(type, name, extension, size, someAttributes)
        {
            if (someAttributes.Length == 1)
            {
                this.Content = someAttributes[0];
            }
            else if (someAttributes.Length > 1)
            {
                foreach (var s in someAttributes)
                {
                    this.Content += s + ";";
                }
                this.Content = this.Content.TrimEnd(';');
            }
        }

        public override List<Tuple<string, string>> GetAttributesWithNames()
        {
            return new List<Tuple<string, string>>
            {
                Tuple.Create("Content", this.Content)
            };
        }
    }
}
