using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    public class Workflow

    {

       private readonly IList<IActivity> _activity;

        public Workflow()
        {
            _activity = new List<IActivity>();
        }

       public void Run()
       {

            foreach (var activity in _activity)
                activity.execute();
       }

        public void Setactivity(IActivity activity)
        {
            _activity.Add(activity);
        }
    }
}
