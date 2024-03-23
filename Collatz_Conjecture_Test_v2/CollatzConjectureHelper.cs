using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture_Test_v2
{
    public class CollatzConjectureHelper
    {
        /// <summary>
        /// Collatz Conjecture (Calculation Only)
        /// </summary>
        /// <param name="X"></param>
        /// <returns></returns>
        public static BigInteger Collatz_Conjecture(ref BigInteger X)
        {
            if (X % 2 == 0) X = X / 2;
            else X = X + 1;
            return X;
        }

        /// <summary>
        /// Struct Version
        /// </summary>
        public struct CollatzConjectureStruct
        {
            public BigInteger X;

            public OddEven OddEvenType;
            public enum OddEven
            {
                Odd,
                Even
            }

            public void Calculate()
            {
                if (X % 2 == 0)
                {
                    OddEvenType = OddEven.Even;
                    this.X = X / 2;
                }
                else
                {
                    OddEvenType = OddEven.Odd;
                    this.X = X + 1;
                }
            }

            public CollatzConjectureStruct(BigInteger X)
            {
                OddEvenType = new OddEven();
                this.X = X;
            }
        }
    }
}
