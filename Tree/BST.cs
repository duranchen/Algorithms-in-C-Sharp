using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class BST<Key, Value> where Key : IComparable
    {

        private class Node
        {
            public Key key;
            public Value value;
            public Node left, right;

            public Node(Key key, Value value)
            {
                this.key = key;
                this.value = value;
                left = null;
                right = null;
            }
        }

        private Node root;
        private int count;

        public BST()
        {
            root = null;
            count = 0;
        }

        public int size()
        {
            return count;
        }

        public bool isEmpty()
        {
            return count == 0;
        }

        public void insert(Key key, Value value)
        {

            root = insert(root, key, value);

        }

        private Node insert(Node node, Key key, Value value)
        {
            if (node == null)
            {
                count++;
                return new Node(key, value);                
            }

            if (node.key.CompareTo(key) < 0)
            {
                node.left = insert(node.left, key, value);
            }
            else if (node.key.CompareTo(key) == 0)
            {
                node.value = value;
            }
            else
            {
                node.right = insert(node.right, key, value);
            }

            return node;

        }
    }
}
