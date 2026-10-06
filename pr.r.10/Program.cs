//***********************************************************************
//* Практическая работа № 10                                            *
//* Выполнила: Кондратюк Е.С., группа 2ИСП                              *
//* Задание: Высокоуровневые языки програмирования                      *
//***********************************************************************
using System;
namespace pr.r._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const uint sizeArrayA = 4, sizeArrayB = 4; // задание размера массива
            uint[,] arrayAB = new uint[sizeArrayA, sizeArrayB];  // массив цел натур чисел
            bool error; // error - флаг обнаружения ошибки при вводе элементов массива
            for (uint i = 0; i < sizeArrayA; i++)
            {
                for (uint j=0; j < sizeArrayB; j++)
                {
                    Console.WriteLine("Введите [" + i + "," + j + "] элемент массива: ");
                    arrayAB [i,j] = 
                }
            }
        }
    }
}
