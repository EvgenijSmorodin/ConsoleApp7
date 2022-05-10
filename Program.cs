using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people;
            int waitingTime = 10;
            int hour;
            int minute;
            Console.Write($"Время приема одного человека {waitingTime} минут. Сколько людей в очереди?") ;
            people = Convert.ToInt32(Console.ReadLine());
            hour = (people * waitingTime) / 60;
            minute = (people * waitingTime) % 60;
            Console.WriteLine($"Время вашего ожидания составит {hour} часов и {minute} минут");
        }
    }
}
