using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practical4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Customer c = new Customer();
            c.Getcarinfo("Hundai", "GJ06MZ1202");
            c.get_day();
            c.get_km();
            c.calrate();
            */

            /*ThreadStart childref = new ThreadStart(ThreadExample.CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            //stop the main thread for some time
            Thread.Sleep(2000);
            //now abort the child
            Console.WriteLine("In Main: Aborting the Child thread");
            childThread.Abort();
            Console.ReadKey();
            */

            /*StackExample stack = new StackExample();
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(40);
            stack.push(50);
            stack.showstack();
            stack.pop();    
            */

            QueueExample queue = new QueueExample();
            queue.enqueue(10);
            queue.enqueue(20);
            queue.enqueue(30);
            queue.enqueue(40);
            queue.enqueue(50);
            queue.show();
            queue.dequeue();
            Console.ReadKey();
        }
    }
}
