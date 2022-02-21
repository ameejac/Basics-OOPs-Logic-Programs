using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicalProgramsPractice
{
    class LogicalCodes
    {
        //by using  third party swap no and string
        public void SWapTwoNo()
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("before swaping:" + a + " " + b);
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("after swaping:" + a + " " + b);
        }
        public void SwapTwoStrings()
        {
            string name1 = "ameeja";
            string name2 = "cherukuru";
            Console.WriteLine("before swapping:" + name1 + " " + name2);
            string name = name1;
            name1 = name2;
            name2 = name;
            Console.WriteLine("after swapping:" + name1 + " " + name2);
        }
        //without third party no and string
        public void noswap()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("before swaping :" + a + " " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swaping :" + a + " " + b);
        }
        public void twostringSwap()
        {
            string name1 = "ameeja";
            string name2 = "cherukuru";
            Console.WriteLine("before swapping:" + name1 + " " + name2);
            name1 = name1 + name2;
            name2 = name1.Substring(0, name1.Length - name2.Length);
            name1 = name1.Substring(name2.Length);
            Console.WriteLine("after swapping:" + name1 + " " + name2);
        }
        public void reverseNo()
        {
            int a = 123;
            int reverse = 0;
            while (a > 0)
            {
                int remainder = a % 10;
                reverse = (reverse * 10) + remainder;
                a = a / 10;
            }
            Console.WriteLine(reverse);
        }
        public void reversestring()
        {
            string name = "ameeja";
            string reverse = string.Empty;
            for (int i = name.Length - 1; i >= 0; i++)
            {
                reverse += name[i];
            }
            Console.WriteLine("reverse string:" + reverse);
        }
        //polyndrome
        public void Polyndrome()
        {
            Console.WriteLine("plzzz enter the num:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                int remainder = num % 10;
                sum = (sum * 10) + remainder;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("If the no is Polyndrome");//ex:121
            }
            else
            {
                Console.WriteLine("if the no is not Polyndrome");//ex:123
            }
        }
        //ex: 371 their digits
        //3= 3^3=3*3*3=27
        //7= 7^3=7*7*7=343
        //1^3=1*1*1=1   ====>  27+343+1=371

        public void armstrong()
        {
            Console.WriteLine("plzzz enter the number");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while (num > 0)
            {
                int remainder = num % 10;
                sum = sum + (remainder * remainder * remainder);
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("If the no is armstrong");
            }
            else
            {
                Console.WriteLine("If the no is not a armstrong");
            }
        }
        public void ArmstorngontherWay()
        {
            Console.WriteLine("{Plzzzz Enter The armstrong no ");
            int num = int.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            for (int i = num; i > 0; i = i / 10)
            {
                int r = i % 10;
                sum = sum + (r * r * r);
            }
            if (sum == temp)
                Console.WriteLine("If The Num Is Armstrong");
            else
                Console.WriteLine("If the Nu is not aArmstrong");
        }
        public void Armstrong3Way()
        {
            Console.WriteLine("plzz enter the num:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = num;
            do
            {
                int r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;
            } while (num > 0);
            if (sum ==temp)
                Console.WriteLine("Its Armstrong");
            else
                Console.WriteLine("Its not Armstrong no");
        }
    }
}
