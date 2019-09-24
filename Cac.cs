/* System */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Which? (*) (/) (+)");
      string fff; // String
      fff = Convert.ToString(Console.ReadLine());

      if (fff == "*") {
        Console.WriteLine("What Number Do You Want To Use?");
        int lll; // Get Number.
        lll = Convert.ToInt32(Console.ReadLine());

        if (lll > 0) {
          Console.WriteLine("What Number Do You Want To * By?");
          int uuu;
          uuu = Convert.ToInt32(Console.ReadLine());
          if (uuu > 0) {
            int nnn = lll * uuu;
            Console.WriteLine($"{lll} * {uuu} = {nnn}");
          }
        }
      }
      if (fff == "/") {
        Console.WriteLine("What Number DO You Want To Be /?");
        int aaa;
        aaa = Convert.ToInt32(Console.ReadLine());

        if (aaa > 0) {
          Console.WriteLine("What umber Do You Want to / by?");
          int ooo;
          ooo = Convert.ToInt32(Console.ReadLine());
          if (ooo > 0) {
            int www = aaa / ooo;
            Console.WriteLine($"{aaa} / {ooo} = {www}");
          }
        }
      }
      if (fff == "+") {
        Console.WriteLine("What Number Do You Want To Add");
        int iii;
        iii = Convert.ToInt32(Console.ReadLine());
        if (iii > 0) {
          Console.WriteLine("What Is The Second Number You Want To Add");
          int hhh;
          hhh = Convert.ToInt32(Console.ReadLine());
          if (hhh > 0) {
            int bbb = iii + hhh;
            Console.WriteLine($"{iii} + {hhh} = {bbb}");
          }
        }
      }
    }
  }
}

