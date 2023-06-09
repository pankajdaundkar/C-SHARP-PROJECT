using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_sallary_2
{
    internal class emp_sallary_2
    {
        static void Main(string[] args)
        {
            

            int Emp_ID,  gross, Bs, Hra, Ta, Da, Pf, pt = 200;
            string Emp_name;

            Console.WriteLine("Entre Emp ID");
            Emp_ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("entre emp name");
            Emp_name = (Console.ReadLine());

            Console.WriteLine(" entre basic sallary of emp");
            Bs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("hra is 40% of basic sallry = {hra}");
            Hra = (Bs * 40 / 100);

            Console.WriteLine("ta is 20 % of basic sallary = {ta}");
            Ta = (Bs * 20 / 100);

            Console.WriteLine(" da is 10 % of basic sallary = {da}");
            Da = (Bs * 10 / 100);

            Console.WriteLine(" pf is 12 % of basic sallary = {pf}");
            Pf = (Bs * 12 / 100);

            Console.WriteLine("gross sallary with allownce = {gross}");
            gross = (Bs + Hra + Ta + Da) - (Pf + pt);


        }
    }
}
