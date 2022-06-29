using System;

namespace StackImpl
{
    /// <summary>
    /// Linear Data Structure, uses Last In First Out(LIFO) Principle
    /// Implemented methods: POP(), PUSH(T value), PEEK(), COUNT(), CONTAINS(T element) and CLEAR()
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Stack<T>
    {
        private T[] _stack;
        private int _size;
        private int _topIndex = -1;
        
        public Stack()
        {
            this._stack = new T[10];
            this._size = 0;
        }
        
        public Stack(int size)
        {
            _size = size;
            _stack = new T[size];
        }
        
        /// <summary>
        /// Removes the last pushed Item from the Stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }

            return _stack[_topIndex--];
        }

        /// <summary>
        /// Adds element to the top of Stack
        /// </summary>
        /// <param name="i"></param>
        /// <exception cref="Exception"></exception>
        public void Push(T i)
        {
            if (IsFull())
            {
                throw new Exception("Stack overflow");
            }

            _stack[++_topIndex] = i;
        }
        
        /// <summary>
        /// Gets the top index element without removing it from the Stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is Empty");
            }

            return _stack[_topIndex];
        }
        
        /// <summary>
        /// Checks if Stack contains <see cref="element"/> provided
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool Contains(T element)
        {
            int size = this._size;
            while (size-- > 0)
            {
                if (element == null)
                {
                    if (this._stack[size] == null)
                        return true;
                }
                else if (this._stack[size] != null && this._stack[size].Equals(element))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Display all elements of the Stack
        /// </summary>
        public void Display()
        {
            for (int i = _topIndex; i > -1; i--)
            {
                Console.WriteLine("Item {0}: {1}", (i + 1), _stack[i]);
            }
        }

        /// <summary>
        /// Checks if stack contains any element
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => _topIndex == -1;

        /// <summary>
        /// Checks for a stack overflow
        /// </summary>
        /// <returns></returns>
        public bool IsFull() => _size == _topIndex + 1;

        /// <summary>
        /// Counts the size of the Stack
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            _size = 0;
            for (int i = _topIndex; i > -1; i--)
            {
                _size++;
            }

            return _size;
        }

        /// <summary>
        /// Clears the Stack to default
        /// </summary>
        public void Clear()
        {
            _topIndex = -1;
            _size = 0;
            _stack = new T[10];
        }
    }
}
