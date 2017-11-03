using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    public abstract class Dbcommand
    {
        public Dbcommand(string commandline)
        {
            if (commandline == null)
                throw new NotImplementedException("Database Command cannot be null");
        }
    }
}
