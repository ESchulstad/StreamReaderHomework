using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamReaderHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader reader = new StreamReader("..\\..\\..\\shakespear.txt");

            string line = reader.ReadLine();

            //uncomment below to print the first line
            //Console.WriteLine(line);

            int lineNumber = 0;

            //uncomment below to print the entire text
            //while(line != null)
            //{
            //    lineNumber++;
            //    Console.WriteLine(line);
            //    line = reader.ReadLine();
            //}

            
            //prints the entire text with all lowercase vowels capitalized
            while(line != null)
            {
                lineNumber++;
                

                line = line.Replace("a", "A");
                line = line.Replace("e", "E");
                line = line.Replace("i","I");
                line = line.Replace("o", "O");
                line = line.Replace("u", "U");

                Console.WriteLine(line);
                line = reader.ReadLine();
                
                  
            }

            
              

        }
    }
}
