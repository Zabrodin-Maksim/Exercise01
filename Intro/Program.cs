using System;
using static System.Console;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1;
class Program {

    static void Main(string[] args) {
        // příklad 1
        string[] @for = { "Josef Novák", "Jindrišská 16", "111 50, Praha 1" };
        for (int ctr = 0; ctr < @for.Length; ctr++)
        {
            Console.WriteLine($"{@for[ctr]}");
        }
        //Console.Write("Josef Novák\nJindrišská 16\n111 50, Praha 1");

        // příklad 2
        for (char i = (char)65; (int)i <= 90; i++) {
            Console.Write(i);
        }

        //příklad 3
        Console.Write("\nPrint your ID\n");
        string rodne = Console.ReadLine();
        int d = rodne[2] *10;
        int e = rodne[3];
        int res = d + e;
        if(res >540 && res < 578) Console.WriteLine("Chyba");
        switch (res)
        {
            case 0: Console.WriteLine("Chyba");
                break;
            case <= 540: Console.WriteLine("Muž");
                break;
            case >= 578: Console.WriteLine("Žena");
                break;
        }
        //    VARIANTA 2
        //    int a = int.Parse(rodne);
        //        int d;
        //        if (rodne[0] == '0')
        //        {
        //            d = a % 100000000;
        //            d = d / 1000000;
        //        }
        //        else
        //        {
        //            d = a % 100000000;
        //            d = d / 1000000;
        //        }
        //        switch (d)
        //    {
        //
        //        case 0: Console.WriteLine("Chyba!!!");
        //            break;
        //        case < 50: Console.WriteLine("muž");
        //            break;
        //        case > 50: Console.WriteLine("žena");
        //            break;
        //    }
        hra();

        void hra() 
        {
            Random random = new Random();
            int value = random.Next(0, 100);
            //Console.WriteLine(value);
            for (int i = 0; i <= 10; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine("prohrál jsi");
                    otazka();
                    break;
                }
                Console.WriteLine("Hra začala! Zadejte číslo:");
                int number = int.Parse(Console.ReadLine());
                if (number == value)
                {
                    Console.WriteLine("Win!!!");
                    otazka();
                    break;
                }
                else if (number > value)
                {
                    Console.WriteLine("vaše číslo je větší než zadané číslo\n Zkus to znovu");
                  
                }
                else
                {
                    Console.WriteLine("vaše číslo je menší než zadané číslo\n Zkus to znovu");
                }
            }
        }
        void otazka()
        {
            Console.WriteLine("Chcete si znovu zahrát?\n ano / ne?");
            string otpoved = Console.ReadLine();
            if (otpoved.Equals("ano")) { hra(); }
            else return;
        }

    }
}

