using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Class1
    {
        static void Main(string[] args)
        {
            var Noun = Console.ReadLine();

            if (Noun.EndsWith("y"))
            {
                Noun = Noun.Remove(Noun.Length - 1);
                Noun += "ies";
            }else if(Noun.EndsWith("o") || Noun.EndsWith("ch") || Noun.EndsWith("s") || Noun.EndsWith("sh") || Noun.EndsWith("x") || Noun.EndsWith("z"))
            {
                Noun += "es";
            }
            else
            {
                Noun += "s";
            }
           
            Console.WriteLine(Noun);
        }
    }
}
