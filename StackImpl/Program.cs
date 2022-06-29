using System;

namespace StackImpl
{
    internal class Program
    {
        private static Stack<int> _stack;
        private static int _capacity;
        
        /// <summary>
        /// Usage: CUSTOM STACK pop, push, peek, count and isempty
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            _capacity = 100;
            // Initialize stack with size: 100
            _stack = new Stack<int>(_capacity);
            
            // Check if stack empty, OUTPUT -> TRUE
            Console.WriteLine(_stack.IsEmpty());

            // Add elements of type INT to stack
            for (int i = 0; i < _capacity; i++)
            {
                _stack.Push(i);
            }
            
            // Count pushed elements, OUTPUT -> 100
            Console.WriteLine("Number of element in stack : {0}", _stack.Count());
            // Check top element, OUTPUT -> 99
            Console.WriteLine("Top of element in stack : {0}", _stack.Peek());
            
            // Display to console stack elements with Indexes, 100 of them
            _stack.Display();
            
            // Pop 90 items from Stack
            for (int i = 0; i < _capacity - 10; i++)
            {
                _stack.Pop();
            }
            
            _stack.Display();
            
            Console.WriteLine("Number of element in stack : {0}", _stack.Count());
            Console.WriteLine("Top of element in stack : {0}", _stack.Peek());
            Console.WriteLine(_stack.Contains(10));

            Console.WriteLine(_stack.IsEmpty());
        }
    }
}
