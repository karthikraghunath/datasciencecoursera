using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    public class SQLConnection : DbConnection

    {
        public override void OpeningDatabase()
        {
            //Console.WriteLine(connectionstring);
         
            if (connectionstring != "" && connectionstring != null)
                Console.WriteLine("SQL Database connected");
            else
                throw new NotImplementedException("Not valid connection string");
        }

        public override void ClosingDatabase()
        {

            if (DateTime.Now - Time > Timeout)
            {
                Console.WriteLine("Closing the connection due to timeout");
                System.Environment.Exit(1);
            }
                
        }
       
    }
}
