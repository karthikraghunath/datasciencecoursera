using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var stopwatch = new Stopwatch();
            TimeSpan duration;
            string oldinput = " ";
            int i = 1;

            while (true)
            { 
                Console.WriteLine("Enter start or stop to invoke or close the stop watch: ");
                string input = Console.ReadLine();
                
            

                if (i > 1)
                {
                    if (oldinput.ToLower() == input.ToLower())
                    {
                        //Console.WriteLine("Wrong Values");
                        throw new InvalidOperationException("Same value cannot be repeated twice back to back");
                        //break;
                    }
                    else
                        oldinput = input.ToLower();

                }
                i += 1;

                oldinput = input.ToLower();

                if (input.ToLower() == "start" )
                {
                    
                    stopwatch.Start();
                }

                if (input.ToLower() == "stop")
                {
                    duration = stopwatch.Stop();
                    Console.WriteLine(duration);
                }
            }
            */

            /*
            var post = new Post();
            int noofvotes = 0;

            Console.WriteLine("Enter the title of the post:" );
            post.Title = Console.ReadLine();

            Console.WriteLine("Enter the description of the post:");
            post.Description = Console.ReadLine();

            post.Created = DateTime.Now.Date;

            while (true)
            {
                Console.WriteLine("Enter 1 to upvote, 2 to donwvote & 3 to know the number of votes for the post" + " " + post.Title);
                string currinput = Console.ReadLine();

               
                switch (currinput)
                {
                    case "1":
                        post.upvotes(1);
                        break;

                    case "2":
                        post.downvotes(1);
                        break;

                    case "3":
                        noofvotes = post.currentvotes();

                        if (noofvotes < 0)
                            Console.WriteLine("Total no of downvotes:" + " " + Math.Abs(noofvotes));
                        else
                            Console.WriteLine("Total no of upvotes:" + " " + Math.Abs(noofvotes));

                        System.Environment.Exit(1);
                        break;
                        
                    
                    default:
                        Console.WriteLine("Not a valid input");
                        break;
                }
                            
            }
            */

            //var Stack = new stack();
            //Stack.push(12);
            //Stack.push(21);
            //Stack.pop();
            //Stack.clear();

            //var sqlconnection = new SQLConnection();

            //sqlconnection.connectionstring = "SQLConnection$karthik$password123";
            //sqlconnection.Timeout = TimeSpan.FromMinutes(1);

            Workflow workflow = new Workflow();
            workflow.Setactivity(new SendSms("9380860870"));

            workflow.Run();
            
            //workflow.Run(new SendSms("9380860870"));
            //workflow.Run(new Sendemail("karthik.raghunath@efb.im"));
            
            
            //sqlconnection.OpeningDatabase();
            

            //while (true)
            //{
            //sqlconnection.ClosingDatabase();
            //}

            
            

        }
    }
}
