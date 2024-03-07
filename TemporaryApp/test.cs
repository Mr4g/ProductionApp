using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductionApp
{
    internal class test
    {
        public double[] item;

        public test() => item = new double[5];

        public void Push(double elements)
        {
            for (var i = 0; i < item.Length;)
            {
                i++;
                Console.WriteLine(i);
                Console.WriteLine(item[i]);
            }
        }
    }
}
