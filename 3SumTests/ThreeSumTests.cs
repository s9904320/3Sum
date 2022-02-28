using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3Sum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace _3Sum.Tests
{
    [TestClass()]
    public class ThreeSumTests
    {
        [TestMethod()]
        public void ThreeSumAnsTestForNull()
        {
            var result = ThreeSum.ThreeSumAns(new int[] { });
            var expect = new List<IList<int>>();
            result.Should().BeEquivalentTo(expect, ans => ans.WithStrictOrdering());
        }

        [TestMethod()]
        public void ThreeSumAnsTestForZero()
        {
            var result = ThreeSum.ThreeSumAns(new int[0]);
            var expect = new List<IList<int>>();
            result.Should().BeEquivalentTo(expect, ans => ans.WithStrictOrdering());
        }

        [TestMethod()]
        public void ThreeSumAnsTestForNormal()
        {
            var result = ThreeSum.ThreeSumAns(new int[6] {-1, 0, 1, 2, -1, -4});
            var expect = new List<IList<int>>() { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } };
            //IList<int> list1 = new int[] { -1, -1, 2 };
            //IList<int> list2 = new int[] { -1, 0, 1 };
            //expect.Add(list1);
            //expect.Add(list2);
            result.Should().BeEquivalentTo(expect, ans => ans.WithStrictOrdering());
        }
    }
}