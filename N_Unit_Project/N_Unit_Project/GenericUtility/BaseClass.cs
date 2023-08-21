using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unit_Project.GenericUtility
{

    [TestFixture]
    public class BaseClass
    {

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
    }
}
