using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // с номера 4
            N22();
            Console.ReadLine();
        }
        public static void N4()
        {
            Console.WriteLine("матрица А");
            int[,] masA = Rand(5, 5, -10, 10);
            Print(masA);
            PoiskMax(masA);
            Console.WriteLine();
            Console.WriteLine("матрица B");
            int[,] masB = Rand(5, 5, -5, 9);
            Print(masB);
            PoiskMax(masB);
            int max = -1000;
            int ki = 0;
            int kj = 0;
            for (int i = 0; i < masA.GetLength(0); i++)
            {
                for (int j = 0; j < masA.GetLength(1); j++)
                {
                    if (i == j && masA[i, j] > max)
                    {
                        max = masA[i, j];
                        ki = i;
                        kj = j;
                    }
                }
            }
            int max1 = -1000;
            int ki1 = 0;
            int kj1 = 0;
            for (int i = 0; i < masB.GetLength(0); i++)
            {
                for (int j = 0; j < masB.GetLength(1); j++)
                {
                    if (i == j && masB[i, j] > max1)
                    {
                        max1 = masB[i, j];
                        ki1 = i;
                        kj1 = j;
                    }
                }
            }

            int[] mas2 = new int[5];
            for (int i = 0; i < masA.GetLength(0); i++)
            {
                for (int j = 0; j < masA.GetLength(1); j++)
                {
                    masA[ki, j] = masB[i, kj1];


                }
            }
            Print(masA);

        }
        public static void N10()
        {
            int[,] mas = Rand(4, 4, -10, 11);
            Print(mas);
            //PoiskMaxDiag(mas);
            //PoiskMinDiag(mas);

            int max = -10000;
            int ki = 0;
            int kj = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i > j && mas[i, j] > max)
                    {
                        max = mas[i, j];
                        ki = i;
                        kj = j;
                    }
                }
            }
            Console.WriteLine("max=" + max);

            int max1 = 10000;
            int ki1 = 0;
            int kj1 = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i < j && mas[i, j] < max1)
                    {
                        max1 = mas[i, j];
                        ki1 = i;
                        kj1 = j;
                    }
                }
            }
            Console.WriteLine("min=" + max1);

            DeleteColumn(ref mas, kj);
            DeleteColumn(ref mas, kj1);
            Print(mas);


        }
        public static void N16()
        {
            int[] mas1 = RandMass(5, -10, 1);
            int[] mas2 = RandMass(5, -5, 8);
            for (int i = 0; i < mas1.Length; i++)
            {
                Console.Write(mas1[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("sorted massiv");
            Buble(mas1);
            Console.WriteLine();
            Console.WriteLine("sorted massiv");
            Buble(mas2);
        }
        public static void N22()
        {
            int[,] mas = Rand(5, 5, -9, 10);
            Print(mas);
            Console.WriteLine("massiv with negstive");
            MassivNegative(mas);
            Console.WriteLine();
            Console.WriteLine("massiv with negative maximum column");
            NegativeColumn(mas);
        }
        static void NegativeColumn(int[,] mas)
        {
            int max = -10000;
            int t = 0;
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (mas[j, i] < 0)
                    {
                        t++;
                        break;
                    }

                }
            }
            Console.WriteLine(t);
            int[] mas2 = new int[t];
            int y = 0;
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                max = -1000;
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    if (mas[j, i] < 0 && mas[j, i] > max)
                    {
                        max = mas[j, i];
                        
                    }
                }
                if (max > -1000)
                {
                    mas2[y] = max;
                    y++;
                }

            }
            for (int i = 0; i < mas2.Length; i++)
            {

                Console.Write(mas2[i] + " ");
            }
        }
        static void MassivNegative(int[,] mas)
        {
            int count = 0;
            int c = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < 0)
                    {
                        count++;
                        break;
                    }
                }
            }
            int[] mas2 = new int[count];
            int f = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                c = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (mas[i, j] < 0)
                    {
                        c++;
                    }
                }
                if (c > 0)
                {
                    mas2[f] = c;
                    f++;
                }
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");

            }
        }
        static void Buble(int[] mas)
        {
            int k = -10;

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] < 0 && mas[j] < 0)
                    {
                        if (mas[i] < mas[j])
                        {
                            k = mas[i];
                            mas[i] = mas[j];
                            mas[j] = k;
                        }
                    }
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");

            }
        }
        static int[,] Rand(int a, int b, int c, int d)
        {
            int[,] mas = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mas[i, j] = random.Next(c, d);
                }
            }
            return mas;
        }
        static int[] RandMass(int a, int c, int d)
        {
            int[] mas = new int[a];
            Random random = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(c, d);
            }
            return mas;
        }
        static void Print(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    Console.Write($"{mas[i, j]}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PoiskMax(int[,] mas)
        {
            int max = -10000;
            int ki = 0;
            int kj = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i == j && mas[i, j] > max)
                    {
                        max = mas[i, j];
                        ki = i;
                        kj = j;
                    }
                }
            }
            int max1 = -10000;
            int ki1 = 0;
            int kj1 = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = mas.GetLength(1) - 1; j >= 0; j--)
                {
                    if (i == j && mas[i, j] > max1)
                    {
                        max1 = mas[i, j];
                        ki1 = i;
                        kj1 = j;
                    }
                }
            }
            int glavMax = 0;
            int gki = 0;
            int gkj = 0;
            if (max1 > max)
            {
                glavMax = max1;
                gki = ki1;
                gkj = kj1;
            }
            else
            {
                glavMax = max;
                gki = ki;
                gkj = kj;

            }
            Console.WriteLine("maximum for =" + glavMax + " i=" + gki + " j=" + gkj);

            //    Console.WriteLine(max1);
            //int max1 = -10000;
            //int ki1 = 0;
            //int kj1 = 0;
            //for (int i = 0; i < mas1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas1.GetLength(1); j++)
            //    {
            //        if (i == j && mas1[i, j] > max1)
            //        {
            //            max1 = mas1[i, j];
            //            ki1 = i;
            //            kj1 = j;
            //        }
            //    }
            //}
            //Console.WriteLine("maximum for B=" + max1 + " i=" + ki1 + " j=" + kj1);

            //for (int i = ki; i < mas.GetLength(0); i++)
            //{
            //    for (int j = kj1; j < mas.GetLength(1); j++)
            //    {

            //    }
            //}
        }
        static void PoiskMaxDiag(int[,] mas)
        {
            int max = -10000;
            int ki = 0;
            int kj = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i > j && mas[i, j] > max)
                    {
                        max = mas[i, j];
                        ki = i;
                        kj = j;
                    }
                }
            }
            Console.WriteLine("max=" + max);
        }
        static void PoiskMinDiag(int[,] mas)
        {
            int max = 10000;
            int ki = 0;
            int kj = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (i < j && mas[i, j] < max)
                    {
                        max = mas[i, j];
                        ki = i;
                        kj = j;
                    }
                }
            }
            Console.WriteLine("min=" + max);
        }
        static void DeleteColumn(ref int[,] mas, int column)
        {

            int[,] mass = new int[mas.GetLength(0), mas.GetLength(1) - 1];


            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int k = 0;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    if (j == column)
                    {
                        continue;
                    }
                    mass[i, k] = mas[i, j];
                    k++;

                }
            }
            mas = mass;

        }
    }
}