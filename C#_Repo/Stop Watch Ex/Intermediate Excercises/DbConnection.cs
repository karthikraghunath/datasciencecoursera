using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    public abstract class DbConnection
    {
        public string connectionstring { get; set; }
        public TimeSpan Timeout { get; set; }
        public DateTime Time;

        public DbConnection()
        {
            
            Time = DateTime.Now;
            //if (connectionstring == null)
            //throw new InvalidOperationException("you cannot pass a null string");

        }

        public abstract void OpeningDatabase();
        public abstract void ClosingDatabase();
         
          
    }
}
