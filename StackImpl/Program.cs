using System.Collections;

namespace StackImpl
{
    internal class Program
    {
        private static Stack _stack;
        
        public static void Main(string[] args)
        {
            //System.Collections.Stack
            _stack = new Stack();
            _stack.Push(10);
            _stack.Push(20);
            _stack.Push(30);
            _stack.Pop();
            _stack.IsEmpty();
        }
    }
}
