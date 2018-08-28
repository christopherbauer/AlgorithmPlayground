using AlgorithmPlayground.SortingAlgorithm;
using NUnit.Framework;

namespace AlgorithmPlayground.Test.SortingAlgorithm
{
    [TestFixture]
    class QuickSortTest
    {
        [Test]
        public static void QuickSort_CorrectBasicSort()
        {
            //arrange
            var algorithm = new QuickSortAlgorithm();
            var data = new[] { 10,4,5,3,2,9,7,1,8,6 };

            //act
            algorithm.Sort(data);

            //assert
            Assert.That(data, Is.Ordered.Ascending);
        }
    }
}
