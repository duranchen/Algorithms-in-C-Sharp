using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BST<Key, Value> where Key : IComparable
    {
        //树中节点为私有类，外部不需要了解节点具体实现
        private class Node
        {
            public Key key;
            public Value value;
            public Node left, right;

            //通过传入key和value，构造一个新节点
            public Node(Key key, Value value)
            {
                this.key = key;
                this.value = value;
                left = null;
                right = null;
            }

            //通过传入一个节点node，构造一个新节点
            public Node(Node node)
            {
                this.key = node.key;
                this.value = node.value;
                this.left = node.left;
                this.right = node.right;
            }
        }

        //树的根节点
        private Node root;
        //树的总节点数
        private int count;

        //树的构造函数，构造一棵空树
        public BST()
        {
            root = null;
            count = 0;
        }

        //返回二分搜索树的节点数
        public int size()
        {
            return count;
        }

        //判断该树是否为空
        public bool isEmpty()
        {
            return count == 0;
        }

        //在树中插入一个新节点
        public void insert(Key key, Value value)
        {

            root = insert(root, key, value);

        }

        //使用递归算法，向根节点为node的树中，插入节点（key,value)，
        //返回插入新节点后树的根
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

        //使用递归算法，在根节点为node的树中，查找key值
        //返回key所对应的value
        private Value search(Node node, Key key)
        {

            if (node == null)
            {
                return default(Value);
            }
            if (node.key.CompareTo(key) == 0)
            {
                return node.value;
            }
            else if (node.key.CompareTo(key) < 0)
            {
                return search(node.left, key);
            }
            else
            {
                return search(node.right, key);
            }

        }

        //使用递归算法，对根节点为node的树进行前序遍历
        //前序遍历：先访问当前节点，在依次递归访问左右子树
        private void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.key);
                preOrder(node.left);
                preOrder(node.right);
            }

        }

        //使用递归算法，对根节点为node的树进行中序遍历
        //中序遍历：先访问左子树，再访问自身节点，最后访问右子树
        private void inOrder(Node node)
        {
            if (node != null)
            {
                inOrder(node.left);
                Console.WriteLine(node.key);
                inOrder(node.right);
            }
        }

        //使用递归算法，对根节点为node的树进行后序遍历
        //后续遍历，先访问左子树，再访问右子树，最后访问自身节点
        private void postOrder(Node node)
        {
            if (node != null)
            {
                postOrder(node.left);
                postOrder(node.right);
                Console.WriteLine(node.key);
            }
        }

        //层序遍历
        public void levelOrder()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);

            while (queue.Count != 0)
            {
                Node node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                Console.WriteLine(node.key);

            }

        }
        
        //迭代查找最小键值，并返回
        public Key minIteration()
        {
            Node node = root;
            while (node.left != null)
            {
                node = node.left;
            }
            return node.key;
        }

        //递归查找最小键值，并返回该键值
        public Key minRecursion()
        {
            Node minNode = minRecursion(root);

            return minNode.key;
        }

        //迭代查找，并返回以node为根节点的树的最小键值所在节点
        private Node minRecursion(Node node)
        {
            if (node.left == null)
            {
                return node;
            }
            else
            {
                return minRecursion(node.left);
            }
        }

        //迭代查找最小键值，并返回该键值
        public Key maxIteration()
        {
            Node node = root;
            while (node.right != null)
            {
                node = node.right;
            }

            return node.key;
        }

        //递归查找最小键值，并返回该键值
        public Key maxRecursion()
        {
            Node maxNode = maxRecursion(root);
            return maxNode.key;
        }

        //递归查找并返回以node为根节点的树的最小键值所在节点
        private Node maxRecursion(Node node)
        {
            if (node.right == null)
            {
                return node;
            }
            else
            {
                return maxRecursion(node.right);
            }
        }

        //删除树中最小键值所在节点
        public void removeMin()
        {
            if (root != null)
            {
                root = removeMin(root);
            }
        }

        //递归算法，删除以node为根节点的树中的最小键值，并返回删除后树的根节点
        private Node removeMin(Node node)
        {
            if (node.left == null)
            {
                Node rightNode = node.right;
                node.right = null;
                count--;
                return rightNode;
            }
            else
            {
                node.left = removeMin(node.left);
                return node;
            }
        }

        //删除树中最大键值所在节点
        public void removeMax()
        {
            if (root != null)
            {
                root = removeMax(root);
            }
        }

        //递归算法，删除以node为根节点的树中的最大键值，并返回删除后树的根节点
        private Node removeMax(Node node)
        {
            if (node.right == null)
            {
                count--;
                return node.left;
            }
            else
            {
                node.right = removeMax(node.left);
                return node;
            }
        }

        //删除树中键值为key的节点
        public void remove(Key key)
        {
            root = remove(root, key);
        }

        //删除以node为根节点的树中键值为key的节点，并返回删除节点后的树的根节点
        private Node remove(Node node, Key key)
        {
            if (node == null)
            {
                return null;
            }

            if (key.CompareTo(node.key) > 0)
            {
                node.right = remove(node.right, key);
                return node;

            }
            else if (key.CompareTo(node.key) < 0)
            {
                node.left = remove(node.left, key);
                return node;
            }
            else
            {
                if (node.left == null)
                {
                    Node rightNode = node.right;
                    count--;
                    return rightNode;
                }

                if (node.right == null)
                {
                    Node leftNode = node.left;
                    node.left = null;
                    count--;
                    return leftNode;
                }

                Node successor = new Node(minRecursion(node.right));

                successor.right = removeMin(node.right);
                successor.left = node.left;

                node.left = node.right = null;

                return successor;

            }
        }
    }
}
