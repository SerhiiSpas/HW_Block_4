using System;
using System.Collections;
using System.Collections.Generic;

namespace Дневник
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, имя ученика");
            String name = Console.ReadLine();

            bool check = false;
            name = name.Trim();

            if (name.Length == 0)
            {
                check = false;
                Console.WriteLine("Вы ввели не верное имя");
            }
            else
            {
                check = true;
                Console.WriteLine("Имя ученика дабавлено в базу");
            }

            List<double> scoreM = new List<double>();
            List<double> scoreL = new List<double>();
            List<double> scorePh = new List<double>();
            List<double> scoreT = new List<double>();

            while (true)
            {
                Console.WriteLine("Выберите команду: " + "\n" +
                "1 - добавить оценку по Математике;" + "\n" + "2 - добавить оценку по Литература;" +
                "\n" + "3 - добавить оценку по Физика;" + "\n" + "4 - добавить оценку по Физ-ра;" + "\n"
                 + "11- Программа определяет максимальную оценку по Математике;" + "\n"
                 + "12- Программа определяет минимальную оценку по Математике;" + "\n"
                 + "13- Программа определяет среднюю оценку по Математике" + "\n");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        Console.WriteLine("Введите, пожалуйста, оценку: 2 - Неуд; 3 - Покатит; 4 - Не плохо ; 5 - Хорошо;");
                        scoreM.Add(Convert.ToDouble(Console.ReadLine()));
                        check = false;
                        do
                        {
                            if (scoreM[0] > 5 || scoreM[0] == 0 || scoreM[0] == 1)
                            {
                                check = false;
                                Console.WriteLine("Ошибка, попробуйте еще раз ввести оценку от 1 до 5 баллов");
                            }
                            else
                            {
                                Console.WriteLine("Оценка внесена в базу");
                            }
                        } while (check);

                        break;
                    case "2":
                        Console.WriteLine("Введите, пожалуйста, оценку: 2 - Неуд; 3 - Покатит; 4 - Не плохо ; 5 - Хорошо;");
                        scoreL.Add(Convert.ToDouble(Console.ReadLine()));
                        check = false;
                        do
                        {
                            if (scoreL[0] > 5 || scoreL[0] == 0 || scoreL[0] == 1)
                            {
                                check = false;
                                Console.WriteLine("Ошибка, попробуйте еще раз ввести оценку от 1 до 5 баллов");
                            }
                            else
                            {
                                Console.WriteLine("Оценка внесена в базу");
                            }
                        } while (check);

                        break;
                    case "3":
                        Console.WriteLine("Введите, пожалуйста, оценку: 2 - Неуд; 3 - Покатит; 4 - Не плохо ; 5 - Хорошо;");
                        scorePh.Add(Convert.ToDouble(Console.ReadLine()));
                        check = false;
                        do
                        {
                            if (scorePh[0] > 5 || scorePh[0] == 0 || scorePh[0] == 1)
                            {
                                check = false;
                                Console.WriteLine("Ошибка, попробуйте еще раз ввести оценку от 1 до 5 баллов");
                            }
                            else
                            {
                                Console.WriteLine("Оценка внесена в базу");
                            }
                        } while (check);

                        break;
                    case "4":
                        Console.WriteLine("Введите, пожалуйста, оценку: 2 - Неуд; 3 - Покатит; 4 - Не плохо ; 5 - Хорошо;");
                        scoreT.Add(Convert.ToDouble(Console.ReadLine()));
                        check = false;
                        do
                        {
                            if (scoreT[0] > 5 || scoreT[0] == 0 || scoreT[0] == 1)
                            {
                                check = false;
                                Console.WriteLine("Ошибка, попробуйте еще раз ввести оценку от 1 до 5 баллов");
                            }
                            else
                            {
                                Console.WriteLine("Оценка внесена в базу");
                            }
                        } while (check);

                        break;

                    case "11":
                        do
                        {
                            if (scoreM.Count == 0)
                            {

                                check = false;
                                Console.WriteLine("Оценка не была добавлена");
                            }
                            else
                            {
                                    scoreM.Sort();

                                    Console.WriteLine($"У {name} максимальной оценкой является {scoreM[scoreM.Count - 1]}" + "\n");

                            }
                        } while (check);
                        

                        break;
                    case "12":
                        do
                        {
                            if (scoreM.Count == 0)
                            {

                                check = false;
                                Console.WriteLine("Оценка не была добавлена");
                            }
                            else
                            {
                                    scoreM.Sort();

                                Console.WriteLine($"У {name} минимальной оценкой является {scoreM[0]}" + "\n");

                            }
                        } while (check);
  
                        break;
                    case "13":
                        do
                        {
                            if (scoreM.Count == 0)
                            {

                                check = false;
                                Console.WriteLine("Оценка не была добавлена");
                            }
                            else
                            {
                                double sumTmp = 0.0;
                                foreach (double scoreElement in scoreM)
                                {
                                    sumTmp += scoreElement;
                                }

                                scoreM.Sort();

                                Console.WriteLine($"У {name} средней оценкой является {sumTmp / scoreM.Count}" + "\n");

                            }
                        } while (check);
                        

                        break;

                    case "=":

                        return;

                    default:
                        Console.WriteLine("Вы ввели недопустимое значение");
                        break;
                }
            }
        }
    }
}
/*Console.WriteLine($"У {name} минимальной оценкой является {scoreM[0]}, максимальной оценкой является {scoreM[scoreM.Count - 1]}," +
    $" средней оценкой является {sumTmp / scoreM.Count}");*/