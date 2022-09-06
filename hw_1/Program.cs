/*Найти в трехмерном массиве max и min элементы.*/

using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace hw_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Программа находит максимальное и минимальное значение в трехмерном массиве");
            while (true)
            {                
                WriteLine("Введите размер массива: (list, row, col)");
                int list, row, col;
                list = Convert.ToInt32(ReadLine());
                row = Convert.ToInt32(ReadLine());
                col = Convert.ToInt32(ReadLine());
                var rand = new Random();
                if (list <= 0 || row <= 0 || col <= 0)                
                {
                    WriteLine("Размер не может быть меньше 1");
                    continue;
                }
                else
                {

                    int[,,] ar_3 = new int[list, row, col];

                    for (int i = 0; i < list; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            for (int k = 0; k < col; k++)
                            {
                                ar_3[i, j, k] = rand.Next(100);
                                Write($"{ar_3[i, j, k]}  ");
                            }
                            WriteLine();
                        }
                        WriteLine();
                    }
                    int[] ar = new int[list * row*col];
                    int c = 0;
                    for (int i = 0; i < list; i++)
                    {
                        for (int j = 0; j < row; j++)
                        {
                            for (int k = 0; k < col; k++)
                            {
                                ar[c] = ar_3[i, j, k];
                                Write($"{ar[c]}  ");
                                c++;
                            }
                        }
                    }
                    WriteLine($"\nМинимальный элемент массива: {ar.Min()}");
                    WriteLine($"Максимальный элемент массива: {ar.Max()}");
                    break;
                }
                
            }
        }
    }
}
