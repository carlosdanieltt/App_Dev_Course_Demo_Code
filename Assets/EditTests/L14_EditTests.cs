using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class L14_EditTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void L14_EditTestsAssert()
        {
            Assert.AreEqual(4, 1 + 3, "Found a problem with adding 1 and 3.");
            Assert.AreNotEqual(4, 1 + 2, "Found a problem with adding 1 and 2.");

            Assert.IsFalse(true && false);

            //Assert.AreEqual(8, 3 + 4, "Found a problem with adding 3 and 4.");
        }
    }
}
