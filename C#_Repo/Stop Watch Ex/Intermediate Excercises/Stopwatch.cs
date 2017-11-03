using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
  public class Stopwatch
    {
        private TimeSpan starttime;
        
        public void Start()
        {
           
           starttime = DateTime.Now.TimeOfDay;

        }

        public TimeSpan Stop()
        {
           
           return (DateTime.Now.TimeOfDay - starttime);
               
        }
    }
}
