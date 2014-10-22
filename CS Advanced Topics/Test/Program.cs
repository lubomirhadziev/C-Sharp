using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var myD = new Dictionary<string, int>() {
            {"hi", 1},
            {"test", 2}
        };
        Console.WriteLine(myD["hi"]);
    }
}
