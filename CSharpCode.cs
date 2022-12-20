using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageSalary
{
    class Sravnenie 
    {
    static void Main(string[] args)
        {
            int[] SalaryList;
            Console.WriteLine("Введите колличество сотрудников: ");
            int  NumberOfWorkers = Convert.ToInt32(Console.ReadLine());
            SalaryList = new int[NumberOfWorkers];      
            for (int i = 0; i < NumberOfWorkers; i++)
            {
                Console.WriteLine("Введлите зарплату сотрудника {0.d} : ", i);
                int SalaryOfEachWorker = Convert.ToInt32(Console.ReadLine());
                SalaryList[i] = SalaryOfEachWorker;

            }  

           Console.WriteLine(string.Join(',', SalaryList));    

        } 
    }
}
