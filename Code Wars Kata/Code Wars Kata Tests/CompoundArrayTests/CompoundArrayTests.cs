﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Wars_Kata.CompundArray;
using NUnit.Framework;

namespace Code_Wars_Kata_Tests.CompoundArrayTests
{
    [TestFixture]
    public static class CompoundArrayClassTests
    {

        [Test]
        public static void test1()
        {
            Assert.AreEqual(new int[] { 1, 9, 2, 8, 3, 7, 4, 6, 5, 6 },
              CompoundArrayClass.CompoundArray(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 9, 8, 7, 6 }));

            Assert.AreEqual(new int[] { 0, 9, 1, 8, 2, 7, 6, 5, 4, 3, 2, 1, 0 },
              CompoundArrayClass.CompoundArray(new int[] { 0, 1, 2 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));

            Assert.AreEqual(new int[] { 11, 21, 12, 22, 23, 24 },
              CompoundArrayClass.CompoundArray(new int[] { 11, 12 }, new int[] { 21, 22, 23, 24 }));
        }
    }
}
