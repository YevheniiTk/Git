using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingData_Tkachenko_
{
    public static class ValidatingData
    {
        const string _invalidCharactersInFileName = "~ # % & * : < > ? / + | \\ / ' { }";

        public static void ValidName(string name)
        {
            char[] badSymbol = _invalidCharactersInFileName.ToArray();
            

            foreach (char e in badSymbol)
            {
                if (name.Contains(e))
                {
                    throw new Exception($"A file name can't contain any of the following characters:" +
                           $"{_invalidCharactersInFileName}");
                }
            }

            if (name.Length > 210)
            {
                throw new Exception("Name of the file exceeds allowed number of characters");
            }
        }
    }
}
