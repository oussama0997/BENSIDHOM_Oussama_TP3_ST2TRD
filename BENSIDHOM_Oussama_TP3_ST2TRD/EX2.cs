using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BENSIDHOM_Oussama_TP3_ST2TRD
{
    class EX2
    {
        private static Mutex mut = new Mutex();
        public void exercice2()
        {
            var t1 = new Thread(f1 => Plop(' ', 50, 10));
            var t2 = new Thread(f2 => Plop('*', 40, 11));
            var t3 = new Thread(f3 => Plop('°', 20, 9));

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }
        private static void Plop(char v1, int frequency, int time)
        {
            float freq = (float)frequency / 1000;
            float n = (float)time / freq;
            int num = (int)n;
            for (float i = 0; i <= num; i++)
            {
                mut.WaitOne();
                Console.Write(v1);
                mut.ReleaseMutex();
                Thread.Sleep(frequency);
            }
        }
    }
}
