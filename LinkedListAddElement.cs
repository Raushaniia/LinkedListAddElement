using System;
using System.Collections.Generic;

namespace LindedsortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> first = list.AddFirst(2);
            LinkedListNode<int> second = list.AddAfter(first, 5);
            LinkedListNode<int> third = list.AddAfter(second, 7);
            LinkedListNode<int> forth = list.AddAfter(third, 8);

            int n = 0;

            if (list==null) {

                throw new NullReferenceException();
            }
            WriteList(list);

            LinkedListNode<int> prev = first;
            LinkedListNode<int> current = first;
            while (current.Value < n || n<first.Value)
            {
                prev = current;
                current = current.Next;
                if (current.Next == first)
                {
                    prev = current;
                    break;
                }
            }
            SetNext(list, prev, n);
            WriteList(list);
        }
        public static void SetNext(LinkedList<int> list, LinkedListNode<int> prev, int n)
        {
            LinkedListNode<int> newNode = new LinkedListNode<int>(n);
            list.AddAfter(prev, n);
        }
        public static void WriteList(LinkedList<int> list)
        {
            int[] array = new int[list.Count];
            list.CopyTo(array, 0);

            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
