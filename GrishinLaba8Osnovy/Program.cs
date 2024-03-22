using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace GrishinLaba8Osnovy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int Fact(int k)
            {
                int fact = 1;
                for (int i = 1; i <= k; i++)
                {
                    fact *= i;
                }
                return fact;
            }

            int Step(int A, int B)
            {
                int st = 1;
                for (int i = 1; i <= B; i++)
                {
                    st *= A;
                }
                return st;
            }

            double Summa(double[] mass)
            {
                double S = 0;
                for (int i = 0; i < mass.Length; i++)
                {
                    S += mass[i];
                }
                return S;
            }

            double[] Massive(int k)
            {
                double[] mass = new double[k];
                Random rnd = new Random();
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.NextDouble();
                }
                return mass;
            }
            void OutPut(double[] mass)
            {
                foreach (var item in mass)
                {
                    Console.WriteLine(item);
                }
            }
            

            Console.Write("Введите длинну массива (t) = ");
            int t = int.Parse(Console.ReadLine());
            double[] z = Massive(t);
            OutPut(z);
            Console.WriteLine($"Сумма массива = {Summa(z)}\n");

            

            Console.Write("Введите длинну массива (p) = ");
            int p = int.Parse(Console.ReadLine());
            double[] s = Massive(p);
            OutPut(s);
            Console.WriteLine($"Сумма массива={Summa(s)}\n");
            
            Console.Write("Введите значение a = "); int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение b = "); int b = int.Parse(Console.ReadLine());
            Console.Write("Введите значение n = "); int n = int.Parse(Console.ReadLine());
            Console.Write("Введите значение m = "); int m = int.Parse(Console.ReadLine());

            double F = Sqrt(Step(a, n) + Step(b, m)) + Fact(n + m) / (Summa(z) - Summa(s));
          
            Console.WriteLine($"Ответ:{F}\n");
            
        }
    }
    
}
