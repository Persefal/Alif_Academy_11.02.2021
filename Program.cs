using System;
using System.Collections;

namespace ConsoleApp18
{
   
    class Program
    {
        delegate T Operation<T>(T alomati1, T alomati2);

        public static T Jam<T>(T alomati1, T alomati2)
        {
            return (dynamic)alomati1 + (dynamic)alomati2;
        }

        public static T Tarh<T>(T alomati1, T alomati2)
        {
            return (dynamic)alomati1 - (dynamic)alomati2;
        }
        public static T Zarb<T>(T alomati1, T alomati2)
        {
            return (dynamic)alomati1 * (dynamic)alomati2;
        }
        public static T Taqsim<T>(T alomati1, T alomati2)
        {
            return (dynamic)alomati1 / (dynamic)alomati2;
        }


        static void Main(string[] args)
        {
            int firstnum;
            Console.WriteLine("Аломати авваларо дохил кунед!:");
            firstnum = int.Parse(Console.ReadLine());
            int secondnum;
            Console.WriteLine("Аломати навбатиро дохил кунед:");
            secondnum = int.Parse(Console.ReadLine());
            int num;
            Console.WriteLine("Амалатонро интихоб кунед!: - Барои истифодаи аломати < + > 1-ро, < - > 2 -ро, <*> 3 -ро </> 4 -ро дохил кунед!");
            num = int.Parse(Console.ReadLine());
            Operation<int> oper = null;

            if (num == 1)
            {
                oper = Jam;
                Console.WriteLine("Чавоби шумо = " + oper.Invoke(firstnum, secondnum));
            }
            
            if (num == 2)
            {
                oper = Tarh;
                Console.WriteLine("Чавоби шумо = " + oper.Invoke(firstnum, secondnum));
             }
            
            
            if (num == 3)
            {
                oper = Zarb;
                Console.WriteLine("Чавоби шумо = " + oper.Invoke(firstnum, secondnum));
            }
            
            if (num == 4)
            {
               oper = Taqsim;
               Console.WriteLine("Чавоби шумо = " + oper.Invoke(firstnum, secondnum));
            }
        }
    }
}
