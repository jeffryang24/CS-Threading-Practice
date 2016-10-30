//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Threading;

//namespace Introduction
//{
//    public class NamedThread
//    {
//        public static void Main(String[] args)
//        {
//            Thread.CurrentThread.Name = "main";
//            Thread worker = new Thread(Go);
//            worker.Name = "worker";
//            worker.Start();
//            Go();
//        }

//        static void Go()
//        {
//            Console.WriteLine("Hello from " + Thread.CurrentThread.Name);
//        }
//    }
//}
