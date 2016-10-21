using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Introduction
{
    class PassParamThread
    {
        static void Main()
        {
            //Thread t = new Thread(() =>
            //{
            //    printMsg("Salam Lemper!");
            //});
            Thread t = new Thread(() => printMsg("Jancuk!!"));
            t.Start();
        }

        static void printMsg(String a)
        {
            Console.WriteLine("Message : " + a);
        }
    }
}
