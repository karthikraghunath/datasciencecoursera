using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO_Operations
{
    public class IO
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\Karthik\Downloads\Get-Visual-Studio.pdf";
            var dotindex = path.IndexOf('.');
            var extn = path.Substring(dotindex);

            Console.WriteLine(dotindex);
            Console.WriteLine(extn);
            Console.WriteLine(Path.GetFileName(path));

            //var fileinfo = new FileInfo(@"C:\C#_Repo\Testfile.txt");
            /*
            var str = File.ReadAllText(@"C:\C#_Repo\Testfile.txt");
            int i = 0;

            foreach (Char c in str)
            {
                if (c != ' ')
                 i += 1;
            }

            Console.WriteLine(i);
            */

            var str = File.ReadAllText(@"C:\C#_Repo\Testfile.txt");
            int i = 0;
            int len = 0;

            foreach (Char c in str)
            {
                if (c == ' ')
                {
                    if (len < i)
                    {
                        len = 0;
                        len = i;
                        i = 0;
                        Console.WriteLine(" ");
                        Console.WriteLine("Length:" + " " + len);
                        //continue;
                    }
                    else
                        i = 0;
                    
                }
                else

                {
                    i += 1;
                    Console.WriteLine("Char:" + " " + c);
                   Console.WriteLine("integer :" + " " + i);
                    
                }

                   
            }
            Console.WriteLine(len);
            //var str = fileinfo.OpenRead;
            //Console.WriteLine(fileinfo.ToString());
            //File.Open(@"C:\C#_Repo\Testfile.txt");
        }
    }
}
    