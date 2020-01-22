using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public class StackExample
    {
        public Stack<int> poll;
        public StackExample()
        {
           poll = new Stack<int>();
        }
        public void push(int number)
        {
            poll.Push(number);
            Console.WriteLine("Push Element {0} ",number);
        }

        public void pop()
        {
            Console.WriteLine("Pop Element {0} ", poll.Peek());
            poll.Pop();
        }

        public void showstack()
        {
            foreach(object obj in poll)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
