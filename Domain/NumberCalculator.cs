using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class NumberCalculator
    {
        int num1 = 0;
        int num2 = 0;
        public NumberCalculator(int number1, int number2)
        {
            num1 = number1;
            num2 = number2;
        }
        /// <summary>
        /// Add two numbers passed into the class
        /// </summary>
        /// <returns>int</returns>
        public int AddNumber()
        {
            return num1 + num2;
        }

        //  Didnt see my initial change
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int MultiplyNumber()
        {
            return num1 * num2;
        }
    }
}
