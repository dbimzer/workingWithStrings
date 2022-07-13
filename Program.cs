using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int age;
            string zodiacSign;
            string workPlace;
            int children;

            Console.Write("Как Вас зовут: ");
            firstName = Console.ReadLine();
            Console.Write("Какая у Вас фамилия: ");
            lastName = Console.ReadLine();
            Console.Write("Сколько Вам лет: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой у Вас знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write("В каком месте Вы работаете: ");
            workPlace = Console.ReadLine();
            Console.Write("Сколько у Вас детей: ");
            children = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вас зовут " + firstName + " " + lastName +
            ". Вам " + age + " лет. Вы " + zodiacSign + ". Вы работаете " +
            workPlace + ". У Вас " + children + " детей.");
        }
    }
}
