using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingData_Tkachenko_.Files
{
    public class Image : SomeFile
    {
        public string Resolution { get; }

        public Image(
            string type,
            string name, 
            string extension, 
            string size, 
            string[] someAttributes) 
            : base(type ,name, extension, size, someAttributes)
        {
            this.Resolution = someAttributes[0];
        }

        public override List<Tuple<string, string>> GetAttributesWithNames()
        {
            return new List<Tuple<string, string>>
            {
                Tuple.Create("Resolution", this.Resolution)
            };
        }
    }
}
