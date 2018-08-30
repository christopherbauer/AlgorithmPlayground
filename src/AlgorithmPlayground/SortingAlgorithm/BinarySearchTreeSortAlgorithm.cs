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

        //This stores the root in a traversable data structure via references

        private void StoreSorted(Node root, int[] arr, ref int i) {
            if (root != null)
            {
                StoreSorted(root.Left, arr, ref i);
                arr[i++] = root.Key;
                StoreSorted(root.Right, arr, ref i);
            }
        }

        private Node Insert(Node root, int key)
        {
            if (root == null)
            {
                return NewNode(key);
            }
            if (key < root.Key)
            {
                root.Left = Insert(root.Left, key);
            }
            else
            {
                root.Right = Insert(root.Right, key);
            }
            return root;
        }
    }
}