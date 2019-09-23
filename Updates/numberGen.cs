/* System */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumber{
  class Program {
    static void Main(string[] args) {
      // Range
      int min;
      int max;

      Console.WriteLine("Insert Number for (MIN)");
      min = Convert.ToInt32(Console.ReadLine());
      if (min > 0) {
        Console.WriteLine("Insert Number for (MAX)");

        max = Convert.ToInt32(Console.ReadLine());
        if (max > 0) {
          Random rnd = new Random();
          Console.Write($"Number: {rnd.Next(min, max)}");
        }
      }
    }
  }
}
