using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_Algorithm.LinkLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class CreateLinkLists
    {
        private ListNode _head;
        private ListNode _tail;
        private int _nodeLength = 0;

        public CreateLinkLists(int[] intNodes) 
        {
            _head = new ListNode(intNodes[0]);
            _tail = _head;

            for (int i = 1; i < intNodes.Length; i++)
            {
                var node = new ListNode(intNodes[i]);
                _tail.next = node;
                _tail = _tail.next;
                _nodeLength++;
            }
            
        }

        public void Append(int value)
        {
            var node = new ListNode(value); 
            this._tail.next = node;
            this._tail = node;
            this._nodeLength++;
        }

        public void Prepend(int value) 
        {
            var node = new ListNode(value);
            node.next = this._head;
            this._head = node;
            this._nodeLength++;
        }


        public void insert(int index, int value)
        {
            if (index >= this._nodeLength)
                this.Append(value);
            if (index <= 0)
                this.Prepend(value);

            var node = new ListNode(value);

            var cursor = this.Traverse(index);

            node.next = cursor.next;
            cursor.next = node;
        }


        public void remove(int index)
        {
            var cursor = this.Traverse(index);
            var unwantedNode = cursor.next;
            cursor.next = unwantedNode.next;
        }

        public ListNode Traverse(int index)
        {
            if (index > this._nodeLength)
                index = this._nodeLength;

            var moves = index - 1;
            var cursor = this._head;

            while (moves > 0)
            {
                moves--;
                cursor = cursor.next;
            }
            return cursor;
        }

        public void PrintList()
        {
            while (_head != null)
            {
                Console.WriteLine(_head.val);
                _head = _head.next;
            };
        }
    }


}
