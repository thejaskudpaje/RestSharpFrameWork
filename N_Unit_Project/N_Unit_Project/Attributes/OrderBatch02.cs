using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unit_Project.Attributes
{

    [TestFixture]
    //   [Category("Order")]
    public class OrderBatch02
    {

        [Test]
        [Order(1)]

        public void Test1()
        {
            Console.WriteLine("Test methos 01--Batch02");
        }

        [Test]
        [Order(2)]

        public void Test2()
        {
            Console.WriteLine("Test methos 02--Batch02");
        }

        [Test]
        public void Test3()
        {
            Console.WriteLine("Test methos 03--Batch02");
        }
    }
}
