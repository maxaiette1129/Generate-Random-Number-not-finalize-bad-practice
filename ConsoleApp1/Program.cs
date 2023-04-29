using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Random rnd = new Random();
            int gen = rnd.Next();
            int[] num = new int[100];
           
            string print = string.Join("\t", num);

            Console.WriteLine("randnum before asigning new random number \n" + print);

            for(int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(100);
                Console.WriteLine(num[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            foreach(int i in num)
            {
                Array.Sort(num);
                num[i] = rnd.Next(0,100);
                string numnum = "";
                numnum = num[i].ToString();

                numnum = string.Join ("\t", numnum);
                
                Console.WriteLine("\n" + numnum);
               
            }
            Console.Clear();
            Array.Sort(num);
            for (int i = 0; i < num.Length;i++)
            {
                Array.Sort(num);
                num[i] = rnd.Next(0,100);
            }

           
            

            foreach(int i in num)
            {   
                
                Console.WriteLine(i + "\t");
            }

          




        }
    }
}