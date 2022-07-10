using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Oleg.Clases
{
    class CProcessor : IData
    {
        public void ProcessData(IPay pay)
        {
            Console.WriteLine(pay.GetData());
        }
    }
}
