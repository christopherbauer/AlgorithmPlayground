using System.Collections.Generic;

namespace AlgorithmPlayground
{
    public class BinaryTreeSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] unSortedList)
        {
            var tree = BuildTree(unSortedList);
            var sorted = tree.InOrderTraverse();

            var i = 0;
            foreach (var value in sorted)
            {
                unSortedList[i] = value;
                i++;
            }
        }

        private Node BuildTree(int[] unSortedList)
        {
            var root = new Node(unSortedList[0]);

            for (var i = 1; i < unSortedList.Length; i++)
            {
                root.Insert(unSortedList[i]);
            }

            return root;
        }

        internal class Node
        {
            private readonly int _value;

            public Node(int value)
            {
                _value = value;
            }

            public IEnumerable<int> InOrderTraverse()
            {
                if (LeftNode != null)
                {
                    foreach (var value in LeftNode.InOrderTraverse())
                    {
                        yield return value;
                    }
                }

                yield return _value;

                if (RightNode != null)
                {
                    foreach (var value in RightNode.InOrderTraverse())
                    {
                        yield return value;
                    }
                }
            }

            public void Insert(int nodeValue)
            {
                if (nodeValue < _value)
                {
                    if (LeftNode == null)
                    {
                        LeftNode = new Node(nodeValue);
                    }
                    else
                    {
                        LeftNode.Insert(nodeValue);
                    }
                }
                else if (nodeValue >= _value)
                {
                    if (RightNode == null)
                    {
                        RightNode = new Node(nodeValue);
                    }
                    else
                    {
                        RightNode.Insert(nodeValue);
                    }
                }
            }

            public Node RightNode { get; set; }

            public Node LeftNode { get; set; }
        }
    }
}