using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Calculator.Program;

namespace Giraffe
{
    public class Abacus
    {
        public int? Num1 { get; set; }
        public int? Num2 { get; set; }
        public Operation? Process { get; set; }

        public Abacus(int num1, int num2, Operation? process) { 
            Num1 = num1;
            Num2 = num2;
            Process = process;
        }

        public int? Calculate()
        {
            if (Num1 != null || Num2 != null)
            {
                if (Process != null)
                {
                    switch (Process)
                    {
                        case Operation.Addition:
                            return Addition();

                        case Operation.Subtraction:
                            return Subtraction();

                        case Operation.Multiplication:
                            return Multiplication();

                        case Operation.Division:
                            return Division();
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("You stupid, use numba");
            }
            return null;
        }

        public int? Addition()
        {
            if (Num1 == null && Num2 == null) return null;

            return Num1 + Num2;
        }

        public int? Subtraction()
        {
            if (Num1 == null && Num2 == null) return null;

            return Num1 - Num2;
        }

        public int? Multiplication()
        {
            if (Num1 == null && Num2 == null) return null;

            return Num1 * Num2;
        }

        public int? Division()
        {
            if (Num1 == null && Num2 == null) return null;

            return Num1 / Num2;
        }
    }
}
