using AlgorithmPlayground.SortingAlgorithm;
using NUnit.Framework;

namespace AlgorithmPlayground.Test.SortingAlgorithm
{
    [TestFixture]
    class BubbleSortAlgorithmTest
    {
        static readonly ISortAlgorithm Algorithm = new BubbleSortAlgorithm();

        [Test]
        public static void Sort_CorrectBasicSort()
        {
            //arrange
            var data = new[] { 10, 4, 5, 3, 2, 9, 7, 1, 8, 6 };

            //act
            Algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
        [Test]
        public static void Sort_CorrectReverseSorted()
        {
            //arrange
            var data = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //act
            Algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
        [Test]
        public static void Sort_CorrectAlreadySorted()
        {
            //arrange
            var data = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //act
            Algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
    }
}
