using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            String ipt;
            Console.WriteLine("hello world");
            Console.WriteLine("정수 입력 : ");
            Console.ReadLine();
            ipt = Console.ReadLine();

            num1 = int.Parse(ipt);
            Console.WriteLine(num1);

            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("첫번쟤 숫자 : ");
            abc:
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("두번 쨰 숫자 : ");

            Console.WriteLine(num1 + num2 + "=" +(num1 + num2));
            Console.WriteLine(num1 - num2 + "=" +(num1 + num2));
            Console.WriteLine(num1 / num2 + "=" + (num1 + num2));
            Console.WriteLine(num1 * num2 + "=" + (num1 + num2));
            goto abc;
        }
    }
}
