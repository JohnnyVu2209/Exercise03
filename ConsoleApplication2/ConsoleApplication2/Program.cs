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
            //Problem6(n);
            Problem7(n);
            
        }
        //--------------------------------------------PROBLEM 6----------------------------------
        static void Problem6(int n)
        {
            DrawHorizontal(n);
            DrawVertical(n);
            DrawDiagonal(n);
        }

        //--------------------------------------------Đường Ngang----------------------------------
        static void DrawHorizontal(int n)
        {
            Console.WriteLine("Horizontal line of stars");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(" * ");

            }
            Console.WriteLine("\t");
        }

        //--------------------------------------------Đường Dọc----------------------------------
        static void DrawVertical(int n)
        {
            Console.WriteLine("Vertical line of stars");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("\t*");

            }
            Console.WriteLine("\t");

        }

        //--------------------------------------------Đường Chéo----------------------------------
        static void DrawDiagonal(int n)
        {
            Console.WriteLine("Diagonal line of n stars");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" * ");    
                    }
                    else
                        Console.Write("  ");
                    
                }
                Console.WriteLine("");
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i+j) == n-1)
                    {
                        Console.Write(" * ");
                    }
                    else
                        Console.Write("  ");

                }
                Console.WriteLine("");
            }
     
        }
        //--------------------------------------------PROBLEM 7----------------------------------
        static void Problem7(int n)
        {
            DrawTriangleUp(n);
        }
        static void DrawTriangleUp(int n)
        {
            int j, z;
            for (int i = 1; i <= n; i++)
            {
                for (j = 0; j <= n-1; j++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z <=  i; z++)
                {
                    if(z==1)
                        Console.WriteLine("*");
                    else if(i == n)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

            }
        }
      }
  }

