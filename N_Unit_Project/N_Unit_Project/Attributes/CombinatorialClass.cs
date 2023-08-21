using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unit_Project.Attributes
{
    [TestFixture]
    public class CombinatorialClass
    {
        [Test]
        //  [Combinatorial]
        [Category("Combinatorial")]
        public void Test([Values(1, 3, 5)] int a, [Values("a", "b")] string b)
        {
            Console.WriteLine($"{a}-->{b}");
        }
    }
}
