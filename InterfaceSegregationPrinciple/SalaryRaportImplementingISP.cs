using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class SalaryRaportImplementingISP : IPrintableExcel, IPrintablePdf
    {
        public void PrintExcel()
        {
            Console.WriteLine("Excel raport printed");
        }

        public void PrintPdf()
        {
            Console.WriteLine("Pdf raport printed");
        }
    }
}
