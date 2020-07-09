using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace программа__3___switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Выберите число:\n 1\n 2\n 3\n 4\n 5\n 6\n 7\n 8\n 9\n 10\n 11\n 12");
           start:
            a = Convert.ToInt32(Console.ReadLine());
             switch (a)
            { 
            case 1:
            Console.WriteLine("Январь");
                break;
              case 2:
            Console.WriteLine("Февраль");
                break;
              case 3:
            Console.WriteLine("Март");
                break;
              case 4:
            Console.WriteLine("Апрель");
                break;
              case 5:
            Console.WriteLine("Май");
                break;
              case 6:
            Console.WriteLine("Июнь");
                break;
              case 7:
            Console.WriteLine("Июль");
                break;
              case 8:
            Console.WriteLine("Август");
                break;
              case 9:
            Console.WriteLine("Сентябрь");
                break;
              case 10:
            Console.WriteLine("Октябрь");
                break;
              case 11:
            Console.WriteLine("Ноябрь");
                break;
              case 12:
            Console.WriteLine("Декабрь");
                break;
                default:
            Console.WriteLine("Месяцев 12.....введи правильное число");
                break;
            }
            Console.ReadKey();
            goto start;
        }
    }
}
