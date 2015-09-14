using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stuff1
{

    class House
    {
        public string Name { get; set; }

        ~House()
        {
            Console.WriteLine("I have been finalized");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10000; i++)
            {
                Test();
            }
            for (int i = 0; i < 100000; i++)
            {
                Test();
            }
            for (int i = 0; i < 1000000; i++)
            {
                Test();
            }
            //GC.Collect();
            // test again
            Console.ReadLine();
            while (true)
            {

            }

            //Console.WriteLine($"Download starting");
            //Stopwatch sw = Stopwatch.StartNew();
            //Task[] tasks = new Task[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    var x = i;
            //    tasks[i]=Task.Run(() => GetBytesFromClient(x));
            //    EventWaitHandle ewh = new AutoResetEvent(false);
            //    //GetBytesFromClient(x);
            //}
            //Task.WaitAll(tasks);
            //Console.WriteLine($"Download finished in {sw.ElapsedMilliseconds}");
            //Console.ReadLine();

        }

        static void Test()
        {
            var o1 = new House { Name = "N1" };
            var o2 = o1;
            o2 = null;
        }

        //static void GetBytesFromClient(int index)
        //{

        //    using (WebClient client = new WebClient())
        //    {
        //        client.Headers["User-Agent"] =
        //        "Mozilla/4.0 (Compatible; Windows NT 5.1; MSIE 6.0) " +
        //        "(compatible; MSIE 6.0; Windows NT 5.1; " +
        //        ".NET CLR 1.1.4322; .NET CLR 2.0.50727)";
        //        // Download data.
        //        byte[] arr = client.DownloadData("http://www.dotnetperls.com/");
        //        byte[] arr2 = client.DownloadData("http://www.dotnetperls.com/");

        //        // Write values.
        //        Console.WriteLine($"--- WebClient result from {index}:{arr.Length+arr2.Length} on thread {Thread.CurrentThread.ManagedThreadId}-- -");

        //        Interlocked.
        //    }
        //}
    }
}
