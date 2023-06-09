using System.Net;

int Emp_ID, Emp_name,  gross,Bs, Hra, Ta, Da, Pf, pt =200;

Console.WriteLine("Entre Emp ID");
Emp_ID = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("entre emp name");
Emp_name = Convert.ToInt32(Console.ReadLine());

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

