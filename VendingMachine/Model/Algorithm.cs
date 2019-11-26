using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Model
{
    class Algorithm
    {
        public int[] result;

        public Algorithm(int[] nominals,int summa)
        {
            result = new int[nominals.Length];

            for (int i = 0; i < nominals.Length; i++)
            {
                while (summa != 0 && summa >= nominals[nominals.Length - i - 1])
                {
                    result[i] = summa / nominals[nominals.Length - i - 1];
                    summa = summa % nominals[nominals.Length - i - 1];
                }
            }
            Array.Reverse(result);
        }
    }
}
