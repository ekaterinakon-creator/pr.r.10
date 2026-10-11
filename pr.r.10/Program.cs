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
            while (true)
            {
                try // поиск ошибок
                {
                    Console.Title = "Практическая работа № 10";
                    Console.ForegroundColor = ConsoleColor.White; // Как в примере на фото
                    Console.BackgroundColor = ConsoleColor.DarkYellow; // Как в примере на фото
                    Console.Clear();
                    Console.WriteLine("Здравствуйте!");

                    const int sizeArrayA = 4, sizeArrayB = 4; // задание размера массива
                    int[,] arrayAB = new int[sizeArrayA, sizeArrayB];  // массив цел натур чисел
                    Random rnd = new Random();
                    Console.WriteLine("\nИсходная матрица");
                    for (int i = 0; i < sizeArrayA; i++)
                    {
                        for (int j = 0; j < sizeArrayB; j++)
                        {
                            arrayAB[i, j] = rnd.Next(-20, 21);
                            Console.Write(arrayAB[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\nСредние арифметические неотрицательных элементов по строкам\n");
                    for (int i = 0; i < sizeArrayA; i++)
                    {
                        int sum = 0;
                        int count = 0;
                        for (int j = 0; j < sizeArrayB; j++)
                        {
                            if (arrayAB[i, j] >= 0)
                            {
                                sum += arrayAB[i, j];
                                count++;
                            }
                        }
                        if (count > 0)
                        {
                            double arithMean = (double)sum / count;
                            Console.WriteLine("Строка " + (i + 1) + ": " + arithMean);
                        }
                        else
                        {
                            Console.WriteLine("Строка " + (i + 1) + ": нет неотрицательных элементов");
                        }
                    }
                    bool rightChoice = false; // флаг: ввел ли пользователь корректное значение
                    while (!rightChoice)
                    {
                        try
                        {
                            Console.WriteLine("\nХотите выполнить программу еще раз? (0 - да, 1 - нет)");
                            int choice = Convert.ToInt32(Console.ReadLine());

                            switch (choice) // проверка выбранного значения
                            {
                                case 0:
                                    rightChoice = true;
                                    break; // программа запустится заново
                                case 1:
                                    return; // выход из программы

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ошибка: Вы ввели другое число!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                            }
                        }
                        catch (FormatException fex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Возникла ошибка: " + fex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        catch (OverflowException oex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Возникла ошибка: " + oex.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }
                }
                catch (Exception ex) // обработка исключения
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Возникла ошибка: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}