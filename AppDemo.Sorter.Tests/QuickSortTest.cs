﻿using System;
using System.Linq;
using AppDemo.Sorter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppDemo.Sorter.Tests
{
    [TestClass]
    public class QuickSortTest
    {
        
        [TestMethod]
        public void TestQuickSortingMethod()
        {
            var _rand = new Random();
            var sorter = new Models.Sorter();
            
            var array = (from i in Enumerable.Range(0, short.MaxValue)
                let num = _rand.Next()
                select num).ToArray();

            var result = sorter.Sort(new QuickSortStrategy(), array);
            Assert.IsTrue(result.Last() > result.First());
        }
    }
}
