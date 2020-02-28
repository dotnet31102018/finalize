using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbitlisten
{
    class Program
    {
        static void Listen()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                //Console.WriteLine("press key to start listening");
                //Console.ReadKey();
                bus.Subscribe<string>("My_Game", HandleClusterNodes);
                Console.WriteLine("Listening ...Press any key to quit");
                Console.ReadKey();
            }
        }

        private static void HandleClusterNodes(string obj)
        {
            Console.WriteLine(obj); // the string will be json which describe work, i.e. write to database
        }

        static void Main(string[] args)
        {
             Listen(); 

            //  SendMessage();
            //  SendMessage();
        }
    }
}
