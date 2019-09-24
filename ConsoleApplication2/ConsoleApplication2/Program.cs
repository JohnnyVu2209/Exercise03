using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert n of star you want");
            int n = Int32.Parse(Console.ReadLine());
           // Problem6(n,'*');
            Problem7(n);

        }
        //--------------------------------------------PROBLEM 6----------------------------------
        static void Problem6(int n, char c)
        {
            DrawHorizontal(n,c);
            DrawVertical(n,c);
            DrawDiagonal(n,c);
        }

        //--------------------------------------------Đường Ngang----------------------------------
        static void DrawHorizontal(int n, char c)
        {
            //Console.WriteLine("Horizontal line of stars");
            for (int i = 0; i < n; i++)
            {
                Console.Write(c);

            }
            
        }

        //--------------------------------------------Đường Dọc----------------------------------
        static void DrawVertical(int n, char c)
        {
            Console.WriteLine("Vertical line of stars");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("\t{0}",c);

            }
            Console.WriteLine("\t");

        }

        //--------------------------------------------Đường Chéo----------------------------------
        //idea :first line draw draw 0 
        static void DrawDiagonal(int n,char c)
        {
            //Console.WriteLine("Diagonal line of n stars");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write(c);
            //        }
            //        else
            //            Console.Write("  ");

            //    }
            //    Console.WriteLine("");
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if ((i + j) == n - 1)
            //        {
            //            Console.Write(c);
            //        }
            //        else
            //            Console.Write("  ");

            //    }
            //    Console.WriteLine("");
            //}

            //another way   

            for (int i = 0; i < n; i++)
            {
                DrawHorizontal(i,' ');
                Console.WriteLine(c);
            }

        }
        //--------------------------------------------PROBLEM 7----------------------------------


        static void Problem7(int n)
        {
            DrawTriangleUp(n,'*');
        }
        //first line : n -1 spaces, 1 star
        //second line : n - 2 spaces, 1 star , 1 space, 1 star
        //third line : n - 3 spaces, 1 star, 3 spaces , 1 star
        //four line : n - 4 spaces , 1 star, 5 spaces, 1 star
        //last line : 2n - 1 stars
        static void DrawTriangleUp(int n , char c)
        {
            //int j, z;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (z = 1; z <= i; z++)
            //    {
            //        if (z == 1)
            //            Console.Write("*");
            //        else if (i == n)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    for (z = (i - 1); z >= 1; z--)
            //    {
            //        if(z == 1)
            //            Console.Write("*");
            //        else if(i == n)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();


            //first line
			    DrawHorizontal(n-1,' ');
                DrawHorizontal(1,c);
                Console.WriteLine();
            //ith line
                int a = 2 , b = 1;
            for (int i = 0; i < n-2; i++)
			{
                DrawHorizontal(n - a, ' '); DrawHorizontal(1, c);
                DrawHorizontal(b, ' '); DrawHorizontal(1, c);
                Console.WriteLine();
                a = a + 1;
                b = b + 2;
			}
            //last line
                DrawHorizontal(2*n-1,'*');
                Console.WriteLine();
                
            }
        }
    }

