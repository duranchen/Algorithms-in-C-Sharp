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

        private Value search(Node node , Key key)
        {

            if (node == null)
            {
                return default(Value);
            }
            if (node.key.CompareTo(key) == 0)
            {
                return node.value;
            } else if(node.key.CompareTo(key) < 0 )
            {
                return search(node.left, key);
            } else
            {
                return search(node.right, key);
            }
            
        }

        public void preOrder()
        {
            preOrder(root);

        }

        //前序遍历
        private void preOrder(Node node)
        {
            if(node != null)
            {
                Console.WriteLine(node.key);
                preOrder(node.left);
                preOrder(node.right);
            }
            
        }

        //中序遍历
        private void inOrder(Node node)
        {
            if(node!= null)
            {
                inOrder(node.left);
                Console.WriteLine(node.key);
                inOrder(node.right);
            }
        }

        //后序遍历
        private void postOrder(Node node)
        {
            if(node != null)
            {
                postOrder(node.left);
                postOrder(node.right);
                Console.WriteLine(node.key);
            }
        }

        //层序遍历
        public void levelOrder()
        {
            Queue<Node> queue  = new Queue<Node>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                Node node = queue.Dequeue();

                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right !=null)
                {
                    queue.Enqueue(node.right);
                }
               
                Console.WriteLine(node.key);   
                
            }

        }

        public Key minIteration()
        {
            Node node = root;
            while(node.left !=null)
            {
                node = node.left;
            }
            return node.key;
        }

        public Key minRecursion()
        {
            Node minNode = minRecursion(root);

            return minNode.key;
        }

        private Node minRecursion(Node node)
        {
            if(node.left == null)
            {
                return node;
            } else
            {
                return minRecursion(node.left);
            }
        }

        public Key maxIteration()
        {
            Node node = root;
            while(node.right != null)
            {
                node = node.right;
            }

            return node.key;
        }

        public Key maxRecursion()
        {
            Node maxNode = maxRecursion(root);
            return maxNode.key;
        }

        private Node maxRecursion(Node node)
        {
            if(node.right == null)
            {
                return node;
            } else
            {
                return maxRecursion(node.right);
            }
        }
    }
}
