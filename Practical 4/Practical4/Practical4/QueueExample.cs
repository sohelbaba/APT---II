using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    class QueueExample
    {
        Queue<int> poll;
        public QueueExample()
        {
            poll = new Queue<int>();
        }

        public void enqueue(int number)
        {
            poll.Enqueue(number);
            Console.WriteLine("Enqueue Data {0} ",number);
        }

        public void dequeue()
        {
            Console.WriteLine("Dequeue Data {0} ", poll.First());
            poll.Dequeue();
        }

        public void show()
        {
            foreach(object obj in poll)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
