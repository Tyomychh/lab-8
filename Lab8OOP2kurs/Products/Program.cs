using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var lines = File.ReadAllLines("productsss.txt");

        var products = lines.Select(line => line.Split(','));

        var groupedProducts = products.GroupBy(p => p[1]);

        foreach (var group in groupedProducts)
        {
            Console.WriteLine(group.Key);
            foreach (var product in group)
            {
                Console.WriteLine(" - {0} ({1})", product[0], product[2]);
            }
            Console.WriteLine();
        }
    }
}
