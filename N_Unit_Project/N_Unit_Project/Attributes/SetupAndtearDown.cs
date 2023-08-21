using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unit_Project.Attributes
{

    [TestFixture]
    [Category("basic")]
    public class SetupAndtearDown //: BaseClass

    {
        [OneTimeSetUp]
        public static void ClassInitialize_test()
        {
            Console.WriteLine("Class initiaalizing block is running");
        }

        [OneTimeTearDown]
        public static void ClassTearDown_test()
        {
            Console.WriteLine("Class Cleanup block is running");
        }

        [SetUp]
        public void Initila_Test()
        {
            Console.WriteLine("Test Setup is happening");
        }
        [TearDown]
        public void Cleaning_Test()
        {
            Console.WriteLine("test cleaning is happenng");
        }
        [SetUp]
        public void Initila_Test02()
        {
            Console.WriteLine("Test Setup is happening 2d time");
        }


        [TearDown]
        public void Cleaning_Test02()
        {
            Console.WriteLine("test cleaning is happenng 2d time");
        }


        [Test(Author = "Thejas")]
        // [Category("basic")]

        public void Test01()
        {
            Console.WriteLine("Test 01");
        }

        [Test]
        //  [Category("basic")]
        public void Test02()
        {
            Console.WriteLine("Test 02");
        }
    }
}
