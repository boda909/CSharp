/* System */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Which Operator: ");
      string Operator;
      Operator = Convert.ToString(Console.ReadLine());

      if (!(Operator == "sqrt" || Operator == "ln")) {
        Console.WriteLine("First Number: ");
        int Num1;
        Num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Second Number: ");
        int Num2;
        Num2 = Convert.ToInt32(Console.ReadLine());

        if (Operator == "+") { Console.WriteLine($"{Num1} + {Num2} = {Add(Num1, Num2)}");
        } else if (Operator == "-") { Console.WriteLine($"{Num1} - {Num2} = {Subtract(Num1, Num2)}");
        } else if (Operator == "*") { Console.WriteLine($"{Num1} * {Num2} = {Multiply(Num1, Num2)}"); 
        } else if (Operator == "/") { Console.WriteLine($"{Num1} / {Num2} = {Divide(Num1, Num2)}");
        } 
      } else {
        if (Operator == "sqrt") {
          Console.WriteLine("SQRT Number: ");
          double Num3;
          Num3 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine($"{Num3} SQRT ({Square(Num3)})");
        } else if (Operator == "ln") {
          Console.WriteLine("LN Number: ");
          double Num4;
          Num4 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine($"{Num4} LN ({LN(Num4)})");
        }
      }
    }
    public static int Add(int Num1, int Num2) { return Num1 + Num2; }
    public static int Subtract(int Num1, int Num2) { return Num1 - Num2; }
    public static int Multiply(int Num1, int Num2) { return Num1 * Num2; }
    public static int Divide(int Num1, int Num2) { return Num1 / Num2; }
    public static double Square(double Num1) { return Math.Sqrt(Num1); }
    public static double LN(double Num1) { return Math.Log(Num1); }
  }
}
