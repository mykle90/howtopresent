using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagdagPresentasjon
{
    class Program
    {
        static void Main(string[] args)
        {

            var six = SumArray(new[] { 1, 2, 3 });
        }

        static int SumArray(int[] toBeSummed)
        {
            var sum = 0;
            for(var i = 0; i<toBeSummed.Length; i++)
            {
                sum += toBeSummed[i];
            }
            return sum;
        }

    }
}
