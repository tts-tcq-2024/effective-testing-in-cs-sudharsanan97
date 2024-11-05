using System.Diagnostics;

namespace MisalignedSpace
{
    class ExcpectedStrings
    {
        Misaligned TestPrint = new Misaligned();
        // Validate color mappings
        static string[] expectedLines = {
                    "0 | White | Blue",
                    "1 | White | Orange",
                    "2 | White | Green",
                    "3 | White | Brown",
                    "4 | White | Slate",
                    "5 | Red | Blue",
                    "6 | Red | Orange",
                    "7 | Red | Green",
                    "8 | Red | Brown",
                    "9 | Red | Slate",
                    "10 | Black | Blue",
                    "11 | Black | Orange",
                    "12 | Black | Green",
                    "13 | Black | Brown",
                    "14 | Black | Slate",
                    "15 | Yellow | Blue",
                    "16 | Yellow | Orange",
                    "17 | Yellow | Green",
                    "18 | Yellow | Brown",
                    "19 | Yellow | Slate",
                    "20 | Violet | Blue",
                    "21 | Violet | Orange",
                    "22 | Violet | Green",
                    "23 | Violet | Brown",
                    "24 | Violet | Slate"
                };

        public static void TestPrintColorMap()
        {
            // Redirect Console output to a string
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                int result = Misaligned.printColorMap();
                string output = sw.ToString();

                // Check the total count of printed lines
                Debug.Assert(result == 25, "Expected 25 lines of output.");

                // Split the output into lines
                var actualLines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // Validate each expected line against actual output
                for (int i = 0; i < expectedLines.Length; i++)
                {
                    Debug.Assert(actualLines[i] == expectedLines[i], $"Expected '{expectedLines[i]}', but got '{actualLines[i]}'.");
                }
            }
        }
    }
}
