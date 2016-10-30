using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPool
{
    class TaskResult
    {
        static void Main()
        {
            Task<String> task = Task.Factory.StartNew(() => DownloadString("http://www.google.com"));
            Console.Write("Please wait...");

            string result = task.Result;
            Console.WriteLine(result);
        }

        static string DownloadString(string url)
        {
            using(var wc = new System.Net.WebClient())
            {
                return wc.DownloadString(url);
            }
        }
    }
}
