using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class SchoolExamRaportViolatingISP : IRaportable
    {
        public void PrintExcel()
        {
            throw new NotImplementedException("Exam can't be printed in excel!");
        }

        public void PrintPdf()
        {
            Console.WriteLine("Exam results in pdf printed");
        }
    }
}
