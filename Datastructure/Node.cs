using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Node
    {
        private string data;
        private Node next = null;

        public string data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node next
        {
            get { return this.next; }
            set { this.next = value; }
        }
    }
}
