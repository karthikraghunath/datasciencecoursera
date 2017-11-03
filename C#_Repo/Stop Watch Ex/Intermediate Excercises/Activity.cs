using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    public interface IActivity
    {
        void execute();
    }

    public class Sendemail : IActivity

    {
        private readonly string _emailid;

        public Sendemail(string emailid)
        {
            _emailid = emailid;

        }

        public void execute()
        {
            Console.WriteLine("Sending email to ID" + " " + _emailid);
        }
    }

    public class SendSms : IActivity
    {
        private readonly string _mobilenum;

        public SendSms(string mobilenum)
        {
            _mobilenum = mobilenum;
 
        }

        public void execute()
        {
            Console.WriteLine("Sending sms to number" + " " + _mobilenum);
        }
    }
}
