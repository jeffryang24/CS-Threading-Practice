using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction
{
    class ThreadStartApp
    {
        static void Main(String[] args)
        {
            //Thread t = new Thread(new ThreadStart(Go));
            Thread t = new Thread(() => Console.WriteLine("Hello!"));   // use lambda
            t.Start();

            //Go();
        }

        static void Go()
        {
            Console.WriteLine("Hello!");
        }
    }
}
