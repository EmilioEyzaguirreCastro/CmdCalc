using System;

namespace ConsoleApp1
{
    class Program
    {
        //START CALCULATING PRECESS
        //Process
        static void Plus()
        {
            try
            {
                double p1 = Convert.ToDouble(Console.ReadLine()), p2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(p1 + p2); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }
        static void Minus()
        {
            try
            {
                double m1 = Convert.ToDouble(Console.ReadLine()), m2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(m1 - m2); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }
        static void Times()
        {
            try
            {
                double t1 = Convert.ToDouble(Console.ReadLine()), t2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(t1 * t2); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }
        static void By()
        {
            try
            {
                double b1 = Convert.ToDouble(Console.ReadLine()), b2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(b1 / b2); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }
        static void Round()
        {
            try
            {
                double rnd1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Round(rnd1)); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }

        }
        static void Max()
        {
            try
            {
                double max1 = Convert.ToDouble(Console.ReadLine()), max2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Max(max1, max2)); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }

        static void Min()
        {
            try
            {
                double min1 = Convert.ToDouble(Console.ReadLine()), min2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Min(min1, min2)); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }

        static void Sqrt()
        {
            try
            {
                double sqrt1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sqrt1)); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }

        static void Cbrt()
        {
            try
            {
                double cbrt1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Cbrt(cbrt1)); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }
        static void Elv()
        {
            try
            {
                double elv1 = Convert.ToDouble(Console.ReadLine()), elv2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Math.Pow(elv1, elv2)); Calculator();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong...");
                Calculator();
            }
        }

        //Gets an operation


        static void Calculator()
        {
            string getOrd = Console.ReadLine();
            /*switch (getOrd)
            {
                case:
            }*/
            if (getOrd == "cmd.plus") { Plus(); }
            if (getOrd == "cmd.minus") { Minus(); }
            if (getOrd == "cmd.times") { Times(); }
            if (getOrd == "cmd.by") { By(); }
            if (getOrd == "cmd.rnd") { Round(); }
            if (getOrd == "cmd.max") { Max(); }
            if (getOrd == "cmd.min") { Min(); }
            if (getOrd == "cmd.sqrt") { Sqrt(); }
            if (getOrd == "cmd.cbrt") { Cbrt(); }
            if (getOrd == "cmd.elv") { Elv(); }
            if (getOrd == "doc()") { Console.WriteLine("Chequee la documentacion aqui:__________"); Calculator(); }
            else { Console.WriteLine("Something went wrong..."); Calculator(); }
        }


        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //pay.
            Console.WriteLine("CmdCalc version 1.0.5 (BETA)");
            Console.WriteLine("Escriba cmd.plus para sumar, cmd.minus para restar, cmd.times para multiplicar y cmd.by para dividir.");
            Console.WriteLine("Para ver una lista completa de los comandos, revise la documentacion escribiendo doc()");
            Calculator();

        }
    }
}
//END CALCULATOR
