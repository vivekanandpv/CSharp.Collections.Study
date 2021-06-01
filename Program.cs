using System;
using System.Collections.Generic;

namespace CSharp.Collections.Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List, LinkedList, Set, Map, Queue, Stack
            
            ICollection<int> intList = new List<int>();   //  always program for an interface
            ICollection<int> intLinkedList = new LinkedList<int>(); //  LinkedList doesn't implement IList<T>, so using ICollection<T>

            ISet<int> intSet = new HashSet<int> { 10, 10, 10, 11, 11};

            Queue<int> intQueue = new Queue<int>();

            Stack<int> intStack = new Stack<int>();

            IDictionary<string, int> dict = new Dictionary<string, int>();
        }
    }
}
