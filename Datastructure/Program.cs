using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    public class program
    {
        static void Main(string[] args)
        {
            
        }

    }
   
    internal class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
    }

    public class SingleLinkedList
    {
        private Node current = null;
        public Node Root { get; set; } = null;
        public int Length { get; set; }
        public void Add(Node node)
        {
            node.Next = null;
            if (Root == null)
            {
                Root = node;
                Length = 1;
                current = Root;
            }
            else
            {
                current.Next = node;
                current = node;
                Length++;
            }
        }
        public Node GetCurrent()
        {
            return current;
        }
        public Node GetRoot()
        {
            current = Root;
            return Root;
        }
        public Node GetNext()
        {
            if (current.Next != null)
            {
                current = current.Next;
                return current;
            }
            else
                return null;
        }
        public int GetLenghtOfList()
        {
            return Length;
        }

    }
}
