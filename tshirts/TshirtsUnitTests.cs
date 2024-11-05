
using System;
using System.Diagnostics;
namespace TshirtSpace

{
    class TestCase
    {
        Tshirt tshirt = new Tshirt();

        static void Main(string[] args)
        {
            Debug.Assert(Tshirt.Size(37) == "S");
            Debug.Assert(Tshirt.Size(40) == "M");
            Debug.Assert(Tshirt.Size(43) == "L");
            Debug.Assert(Tshirt.Size(38) == "M");
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
