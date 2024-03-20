using KnapsackProblem;
using System;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMehodForSollution()
        {
            Problem problem = new Problem();

            if (problem.Solve().ResultItems.Count != 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMehodForNoSollution()
        {
            int n = 10;
            int seed = 10;
            int capacity = 10;
            List<Item> Items = new List<Item>();
            Random random = new Random(seed);
            Problem problem = new Problem(n, capacity, seed);

            for (int i = 0; i < n; i++)
            {
                Items.Add(new Item(random, 15, 24));
            }
            problem.Items = Items;

            if (problem.Solve().ResultItems.Count == 0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMethodForDiffrentOrderItems()
        {
            Problem problem_1 = new Problem();
            Problem problem_2 = new Problem();
            problem_2.Items.Reverse();
            Assert.AreEqual(problem_1.Solve().TotalValue, problem_2.Solve().TotalValue);
        }

        [TestMethod]
        public void TestMehodForCertainCase()
        {
            Problem problem = new Problem(24, 10, 45);
            Assert.IsTrue(10 >= problem.Solve().TotalWeight);
        }

        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (var n in sizes)
            {
                Problem problem = new Problem(n);
                Assert.AreEqual(n, problem.Items.Count);
            }
        }

        [TestMethod]
        public void TestMethodMaxCapacity()
        {
            List<int> capacities = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (var capacity in capacities)
            {
                Problem problem = new Problem(capacity: capacity);
                Assert.IsTrue(capacity >= problem.Solve().TotalWeight);
            }
        }

        [TestMethod]
        public void TestMethodForNegativeCapacity()
        {
            Problem problem = new Problem(capacity: -20);
            Assert.AreEqual(problem.Solve().ResultItems.Count, 0);
        }

        [TestMethod]
        public void TestMethodForLists()
        {
            Problem problem = new Problem();

            if (problem.Solve().ResultItems.Count > problem.Items.Count)
            {
                Assert.Fail();
            }
            Assert.IsTrue(true);
        }

    }
}