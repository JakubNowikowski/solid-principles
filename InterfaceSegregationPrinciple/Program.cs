using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violating Interface Segregation Principle

            List<IRaportable> raports = new List<IRaportable>();

            raports.Add(new SalaryRaportViolatingISP());
            raports.Add(new SchoolExamRaportViolatingISP());

            foreach (var raport in raports)
                raport.PrintExcel(); // throws error on SchoolExamRaportViolatingISP object




            // Implementing Interface Segregation Principle

            List<IPrintablePdf> pdfRaports = new List<IPrintablePdf>();

            pdfRaports.Add(new SalaryRaportImplementingISP());
            pdfRaports.Add(new SchoolExamRaportImplementingISP());

            foreach (var pdfRaport in pdfRaports)
                pdfRaport.PrintPdf();


            Console.ReadKey();
        }
    }
}
