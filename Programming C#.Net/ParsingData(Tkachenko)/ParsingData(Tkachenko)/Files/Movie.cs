using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingData_Tkachenko_.Files
{
    public class Movie : Image
    {
        public string Duration { get; }

        public Movie(
            string type,
            string name,
            string extension,
            string size,
            string[] someAttributes)
            : base(type, name, extension, size, someAttributes)
        {
            this.Duration = someAttributes.Last();
        }

        public override List<Tuple<string, string>> GetAttributesWithNames()
        {
            List<Tuple<string, string>> result = base.GetAttributesWithNames();

            result.AddRange
                (new List<Tuple<string, string>>()
                {
                    Tuple.Create("Duration", this.Duration)
                });
            
            return result;
        }
    }
}
