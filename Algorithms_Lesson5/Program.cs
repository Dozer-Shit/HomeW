using System;
using System.Collections.Generic;

namespace Algorithms_Lesson5
{
    internal static class Program
    {
        private class MyQueue
        {
            private int[] _array;
            private int _head;
            private int _tail;

            private MyQueue()
            {
                _array = new int[3];
            }

            private int Count { get; set; }

            private int Deq()
            {
                if (Count == 0)
                    throw new InvalidOperationException();
                int local = _array[_head];
                _array[_head] = 0;
                _head = (_head + 1) % _array.Length;
                Count--;
                return local;
            }

            private void Enq(int item)
            {
                if (Count == _array.Length)
                {
                    var cap = _array.Length * 2;
                    SetCap(cap);
                }

                _array[_tail] = item;
                _tail = (_tail + 1) % _array.Length;
                Count++;
            }

            private void SetCap(int cap)
            {
                int[] destArray = new int[cap];
                if (Count > 0)
                {
                    if (_head < _tail)
                    {
                        Array.Copy(_array, _head, destArray, 0, Count);
                    }
                    
                    else
                    {
                        Array.Copy(_array, _head, destArray, 0, _array.Length - _head);
                        Array.Copy(_array, 0, destArray, _array.Length - _head, _tail);
                    }
                }

                _array = destArray;
                _head = 0;
                _tail = Count == cap ? 0 : Count;
            }

            public static void Main()
            {
                // Реализовать очередь.

                var myQueue = new MyQueue();
                myQueue.Enq(1);
                myQueue.Enq(2);
                myQueue.Enq(3);
                myQueue.Enq(4);
                myQueue.Enq(5);
                myQueue.Enq(6);

                while (myQueue.Count > 0)
                {
                    Console.WriteLine(myQueue.Deq());
                }

                Console.ReadKey();

                // Написать программу, которая определяет, является ли введенная скобочная последовательность правильной.

                Stack<char> stack = new Stack<char>();
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();

                if (str != null)
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '(')
                        {
                            stack.Push('(');
                        }

                        else if (str[i] == ')' & stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }

                Console.WriteLine(stack.Count == 0 ? "Выражение верное." : "Выражение не верное!");
                Console.ReadKey();
            }
        }
    }
}