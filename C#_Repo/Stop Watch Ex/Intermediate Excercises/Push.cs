using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Intermediate_Excercises
{
    public class stack
    {
        public List<int> list = new List<int>();
        public string test;
        public int i = 0;

        public void  push (object obj)
         {
            
            if (obj != null)
            { 
                list.Add((int) obj);
                i += 1;
            }
        }

        public void pop()
        {
            bool isEmpty = !list.Any();
            if (!isEmpty)
            {
                List<int> sortedTrans = list.OrderByDescending(x => x).ToList();
                Console.WriteLine(sortedTrans.ElementAt(0));
                sortedTrans.RemoveAt(0);
                list.RemoveAt(i - 1);
                i -= 1;
            }
            else
                System.Environment.Exit(1);
            //Console.WriteLine("List is empty");
        }

        public void clear()
        {
            list.Clear();
        }
    }
}
 