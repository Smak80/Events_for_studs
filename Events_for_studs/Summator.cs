using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events_for_studs
{
    class Summator
    {

        public int Result
        {
            get;
            set;
        }

        public void Start()
        {
            new Thread(sum).Start();
        }

        private void sum()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                sum += i;
            }

            Result = sum;
        }
    }
}
