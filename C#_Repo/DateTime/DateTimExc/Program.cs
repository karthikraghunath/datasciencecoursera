using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DateTimExc
{
    public class Program
    {
        static void Main(string[] args)
        {
            var datetime = new DateTime(2015, 1, 2);
            datetime.AddYears(1);
            Console.WriteLine(datetime.Year);

            var hr= TimeSpan.FromHours(1);
            Console.WriteLine(hr);
            Console.WriteLine(DateTime.Now.Year);

            //To check if the given input is in valid time format
            /*
            Console.WriteLine("Enter the time value: ");
            string time = Console.ReadLine();

            try
            {
                var datetime1 = new DateTime();
                datetime1 = DateTime.Parse(time);
                Console.WriteLine("Proper time format");
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid Time");
            }
            */

            /*
            Console.WriteLine("Enter the input:");
            String textToChange = Console.ReadLine();
            System.Text.StringBuilder resultBuilder = new System.Text.StringBuilder();

            foreach (char c in textToChange)
            {
                // Replace anything, but letters and digits, with space
                if (!Char.IsLetterOrDigit(c))
                {
                    resultBuilder.Append(" ");
                }
                else
                {
                    resultBuilder.Append(c);
                }
            }

            string result = resultBuilder.ToString();

            // Make result string all lowercase, because ToTitleCase does not change all uppercase correctly
            result = result.ToLower();
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            result = myTI.ToTitleCase(result).Replace(" ", String.Empty);
            
            Console.WriteLine(result);
            */

            /*
            String[] strarray = str.Split('-');
            int i = 0;
            int j = 0;
            int h = 0;

            foreach(string s in strarray)
            {
                i += 1;
                int num = Convert.ToInt32(s);
                if (i > 1)
                {
                    if (j != num && h != num) 
                    {
                        Console.WriteLine("You are fucked. Not consecutive");
                        break;
                    }

                }
                j = num + 1;
                h = num - 1;
            }
            Console.WriteLine("Numbers are consecutive");
            */

            /*
            Console.WriteLine("Enter consecutive numbers:");
            var str = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(str))
              { 
                //Console.WriteLine("Poda");
                Environment.Exit(0);
              }

            String[] strarray = str.Split('-');
            var mylist = new List<int>();

            foreach (string s in strarray)
            {
                int num = Convert.ToInt32(s);
                if (mylist.Contains(num))
                { 
                    Console.WriteLine("Duplicate Value");
                    break;
                }
                mylist.Add(num);

            }
            //Console.WriteLine("Numbers are consecutive");
            */

            Console.WriteLine("Enter an english word:  ");
            String textToChange = Console.ReadLine();

            var newstring = textToChange.ToLower();
            var i = 0;

            var resultBuilder = new StringBuilder();
            foreach (char c in newstring)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    i += 1;
            }
            Console.WriteLine(i);
        }
    }

    
}
