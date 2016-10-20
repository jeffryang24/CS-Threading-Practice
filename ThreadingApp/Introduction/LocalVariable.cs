//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Introduction
//{
//    class LocalVariable
//    {
//        //bool done;
//        static bool done;   // static field is shared between all threads

//        static readonly object locker = new object();
//        static void Main(String[] args)
//        {
//            //LocalVariable lv = new LocalVariable();
//            //new Thread(lv.Go).Start();
//            //lv.Go();
//            new Thread(Go).Start();
//            Go();
//        }

//        //static void Go()
//        //{
//        //    for(int i = 0; i < 5; i++)
//        //    {
//        //        Console.Write("?");
//        //    }
//        //}

//        //void Go()
//        //{
//        //    for (int i = 0; i < 5; i++)
//        //    {
//        //        if (!done)
//        //        {
//        //            done = true;
//        //            Console.WriteLine("Done");
//        //        }
//        //    }
//        //}

//        //static void Go()
//        //{
//        //    for (int i = 0; i < 5; i++)
//        //    {
//        //        if (!done)
//        //        {
//        //            //done = true;
//        //            Console.WriteLine("Done");
//        //            done = true;
//        //        }
//        //    }
//        //}

//        static void Go()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                lock (locker)
//                {
//                    if (!done)
//                    {
//                        //done = true;
//                        Console.WriteLine("Done");
//                        done = true;
//                    }
//                }
//            }
//        }
//    }
//}
