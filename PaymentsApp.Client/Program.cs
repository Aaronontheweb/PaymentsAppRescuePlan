using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace PaymentsApp.Client
{
    class Program
    {
        private static ActorSystem System;
        static void Main(string[] args)
        {
            System = ActorSystem.Create("paymentsApp");
        }
    }
}
