using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class L14_PlayTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void L14_PlayTestsTranslate()
        {
            GameObject gameObject = new GameObject();
            gameObject.transform.position = new Vector3(0, 0, 0);

            gameObject.transform.Translate(new Vector3(2, 3, 4));

            Assert.AreEqual(new Vector3(2, 3, 4), gameObject.transform.position, "Found a problem when translating an object");

            //Assert.AreEqual(new Vector3(1, 3, 4), gameObject.transform.position, "Found a problem when translating a second object");
        }
    }
}
