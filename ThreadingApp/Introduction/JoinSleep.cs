using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction
{
    class JoinSleep
    {
        static void Main(String[] args)
        {
            Thread tt = new Thread(Go);
            Thread.Sleep(2000);
            tt.Start();
            tt.Join();
            Console.WriteLine("Thread has Ended!");
        }

        static void Go()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
    }
}
