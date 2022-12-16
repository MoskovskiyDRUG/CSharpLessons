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
            Console.WriteLine("Введлите колличество сотрудников: ");
            int Workers = Convert.ToInt32(Console.ReadLine());
            int SalaryWorkers;
            while (Workers > 0)
            {
                Console.WriteLine("Введлите зарплату сотрудника: ");
                SalaryWorkers = Convert.ToInt32(Console.ReadLine());
                Workers--;
            }
            

        
            
        }        

    } 
}
