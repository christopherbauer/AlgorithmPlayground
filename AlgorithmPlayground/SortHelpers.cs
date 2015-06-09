namespace AlgorithmPlayground
{
    public static class SortHelpers
    {
        public static void Swap<T>(T[] list, int a, int b)
        {
            var tempA = list[a];
            list[a] = list[b];
            list[b] = tempA;
        }
    }
}