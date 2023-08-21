using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unit_Project.Attributes
{
    [TestFixture]
    [Category("Ignore")]
    // [Ignore("Ignore this fixture")]
    public class IgnoreClass
    {
        [Test]
        [Ignore("Dont run this")]
        public void Test01()
        {
            Console.WriteLine("Test 01 executing");
        }

        [Test]
        public void Test02()
        {
            Console.WriteLine("Test 02 executing");
        }

        [Test]
        [Ignore("Run this after", Until = "2023-8-17 15:55:00Z")]
        public void Test03()
        {
            Console.WriteLine("Test 03 executing");
        }
        [Test]
        public void Test04()
        {
            Console.WriteLine("Test 04 executing");
        }
    }
}
