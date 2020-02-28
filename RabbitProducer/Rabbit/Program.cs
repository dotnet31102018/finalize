using EasyNetQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rabbit
{

    class Program
    {
        static void SendMessage()
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                Console.WriteLine("Press any key to send the message");
                Thread.Sleep(1500);
                bus.Publish("{\"text\": \"Hello World\"}", "My_Game");
                Console.WriteLine("Message sent ... Press any key to quit");
            }
        }
      
        static void Main(string[] args)
        {

            SendMessage();
            SendMessage();

        }

    }
}
