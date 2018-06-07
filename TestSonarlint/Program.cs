using System;
using ClassLibrary1;

namespace TestSonarlint
{
    internal class Program
    {
        private static void Main()
        {
            var utils = new Utility();
            Console.WriteLine(utils.GetDateTimeNow());
        }
    }
}
