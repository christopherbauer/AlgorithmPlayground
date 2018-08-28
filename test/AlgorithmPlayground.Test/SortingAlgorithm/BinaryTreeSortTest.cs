using AlgorithmPlayground.SortingAlgorithm;
using NUnit.Framework;

namespace AlgorithmPlayground.Test.SortingAlgorithm
{
    [TestFixture]
    class BinaryTreeSortTest
    {
        [Test]
        public static void TreeSort_CorrectBasicSort()
        {
            //arrange
            var algorithm = new BinarySearchTreeSortAlgorithm();
            var data = new[] { 10,4,5,3,2,9,7,1,8,6 };

            //act
            algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
        [Test]
        public static void TreeSort_CorrectReverseSorted()
        {
            //arrange
            var algorithm = new BinarySearchTreeSortAlgorithm();
            var data = new[] { 10,9,8,7,6,5,4,3,2,1 };

            //act
            algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
        [Test]
        public static void TreeSort_CorrectAlreadySorted()
        {
            //arrange
            var algorithm = new BinarySearchTreeSortAlgorithm();
            var data = new[] { 1,2,3,4,5,6,7,8,9,10 };

            //act
            algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
    }
}
