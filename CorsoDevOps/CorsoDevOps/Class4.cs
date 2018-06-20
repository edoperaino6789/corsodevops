using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoDevOps
{
    public class Calculator
    {
        public int ADD(int a, int b)
        {
            return a + b;
        }
        public int Subtrack (int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            
            {

                if (b == 0)
                    throw new ArgumentException("Divisione per zero");
                return a / b;

            }

            
        }
   }
}
