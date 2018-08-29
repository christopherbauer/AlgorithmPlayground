using System.Collections.Generic;

namespace AlgorithmPlayground.SortingAlgorithm
{
    public class BinarySearchTreeSortAlgorithm : ISortAlgorithm
    {
        public void Sort(int[] arr)
        {
            TreeSort(arr, arr.Length);
        }

        private void TreeSort(int[] arr, int size)
        {
            Node root = null;

            int i;
            for (i = 0; i < size; i++)
            {
                root = Insert(root, arr[i]);
            }

            int trackerInt = 0;
            StoreSorted(root, arr, ref trackerInt);
        }

        private class Node
        {
            public int Key { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }

        private Node NewNode(int value)
        {
            return new Node {Key = value};
        }

        //This stores the node in a traversable data structure via references

        private void StoreSorted(Node root, int[] arr, ref int i) {
            if (root != null)
            {
                StoreSorted(root.Left, arr, ref i);
                arr[i++] = root.Key;
                StoreSorted(root.Right, arr, ref i);
            }
        }

        private Node Insert(Node node, int key)
        {
            if (node == null)
            {
                return NewNode(key);
            }
            if (key < node.Key)
            {
                node.Left = Insert(node.Left, key);
            }
            else
            {
                node.Right = Insert(node.Right, key);
            }
            return node;
        }
    }
}