using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalclateApp
{
    /// <summary>
    /// Maths methods
    /// </summary>
    public enum MathsMethod
    {
        Add, Subtract, Multiply, Divide
    }
    /// <summary>
    /// Calculation sample defination
    /// </summary>
    public class CalculationSample
    {
       
        /// <summary>
        /// This function supports all the calculation methods defined in maths method.
        /// </summary>
        /// <param name="a">This is integer type.</param>
        /// <param name="b">This is integer type.</param>
        /// <param name="mathsMethod">This is integer type.</param>
        /// <returns>Integer result set.</returns>
        public int DoAllCalculation(int a, int b, MathsMethod mathsMethod)
        {

            int result = 0;

            switch (mathsMethod)
            {
                case MathsMethod.Add:
                    result = Add(a, b);
                    break;
                case MathsMethod.Subtract:
                    result = Subtract(a, b);
                    break;
                case MathsMethod.Multiply:
                    result = Multiplication(a, b);
                    break;
                case MathsMethod.Divide:
                    result = Division(a, b);
                    break;
                default:
                    return 0;
            };
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int Division(int a, int b)
        {
            return a / b;
        }

        private static int Multiplication(int a, int b)
        {
            return a * b;
        }

        private static int Subtract(int a, int b)
        {
            return a - b;
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
