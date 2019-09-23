/* System */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Insert the number"); 
      int fff; // Number
        fff = Convert.ToInt32(Console.ReadLine());
        if ((fff % 2) == 0) { // Checks for even or odd
          Console.WriteLine($"Number {fff} Even"); // If number is even
        } else {
          Console.WriteLine($"Number {fff} Not Even"); // If number is odd
        }
    }
  }
}
