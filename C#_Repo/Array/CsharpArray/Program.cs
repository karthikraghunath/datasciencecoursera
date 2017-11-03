using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpArray;

namespace CsharpArray
{
    public class Arraylist
    {
        static void Main(string[] args)
        {
            /*
            var names = new List<string>();

            while(true)
            {
                Console.WriteLine("Type a name (or enter to quit): ");
                var str = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(str))
                {
                    break;//Console.WriteLine("There are no likes for this post");
                }

                names.Add(str);
            }

            Console.WriteLine(names.Count);

            if (names.Count > 2)
                Console.WriteLine("{0} {1} and {2} likes your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
            else if (names.Count == 1)
                Console.WriteLine("{0} likes your post.", names[0]);
            else
                Console.WriteLine();
            */

            /*
            Console.WriteLine("Enter the names of your friends:"  );
            var str = Convert.ToString(Console.ReadLine());

            if (str == "")
                Console.WriteLine("There are no likes for this post");

            if (!str.Contains(','))
                Console.WriteLine(str + " " + "likes your post");
            else
            { 
            string[] strarray = str.Split(',');
            var newstrarray = new string[strarray.Length];


            for (int i=0; i<strarray.Length; i++)
            {
                newstrarray[i] = Convert.ToString(strarray[i].Trim());
                
            }

            int lastelement = newstrarray.Length;
            
            foreach (string newstr in newstrarray)
                Console.WriteLine(newstr);
            }
            */

            /*
            Console.WriteLine("Enter the name: ");

            var name = Console.ReadLine();
            var newchararray = new char[name.Length];

            int i = 0;
            string newstr;

            foreach (char c in name)
            {
                newchararray[i] = c;
                i++;
            }

            Array.Reverse(newchararray);

            newstr = new string(newchararray); //Used to convert char to string

            Console.WriteLine(newstr);
            */

            /*
            var numbers = new List<int>();
            while (true)
            {
                //Console.WriteLine("Count" + " " + numbers.Count);
                Console.WriteLine("Please enter the numbers: ");
                
                if (numbers.Count >= 5)
                    break;
                else
                {
                    var currnum = Convert.ToInt32(Console.ReadLine());
                    if (numbers.Contains(currnum))
                        Console.WriteLine("Number already available");
                    else
                      numbers.Add(currnum);
                }
                
            }

            numbers.Sort();
            foreach (int num in numbers)
                Console.WriteLine(num);
           */

            /*
            //Display unique numbers
            var numbers = new List<int>();
            
            while(true)
            {
                Console.WriteLine("Enter the number (or 'Quit' to exit) :");
                string str = Console.ReadLine();
                string newstr = str.ToLower();

                if (newstr == "quit")
                    break;
                else
                {
                    var currnum = Convert.ToInt32(newstr);
                    if (numbers.Contains(currnum))
                        continue;
                    else
                        numbers.Add(currnum);
                }
            }

            foreach (int num in numbers)
                Console.WriteLine(num);
           */

            /*
            //Displaying three smallest numbers in the list
            Console.WriteLine("Enter list of comma seperated numbers: ");
            var str = Console.ReadLine();
            int j = 0; ;

            if (String.IsNullOrWhiteSpace(str))
                Console.WriteLine("This is not a valid List");

            string[] strarray = str.Split(',');

            //var numstr = new List<string>(str.Split(','));
            for (int i = 0;i<strarray.Length; i++)
            {
                strarray[i] = strarray[i].Trim();
            }

            if (strarray.Length < 3)
                Console.WriteLine("Length cannot be less than three");
            
            //Array assigned to List
            
            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));
            

            int[] intarray = Array.ConvertAll(strarray, int.Parse); //convert str array to int array

            //Array.Copy((strarray), intarray,strarray.Length);
            Array.Sort(intarray);

            Console.WriteLine("The Three Smallest numbers are: ");
            foreach (int m in intarray)
            { 
                j += 1;
                if (j > 3)
                    break;
                else
                    Console.WriteLine(m);
            }
         
          */  
        }
    }
}
