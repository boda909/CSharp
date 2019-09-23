/* System */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumber {
    class Program {
        static void Main(string[] args) {
            // Range
            int min = 1;
            int max = 10; 
            
            Random rnd = new Random();
            Console.Write($"Number: {rnd.Next(min, max)}");
        }
    }
}
