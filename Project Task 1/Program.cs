using System;

namespace Project_Task_1
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Write Deapason1:");
            int Deapason1= int.Parse(Console.ReadLine());
            Console.WriteLine("Write Deapason2:");
            int Deapason2= int.Parse(Console.ReadLine());
            
            Func(Deapason1,Deapason2);
        }
        public static void Func(int Deapason1,int Deapason2)
        {  
            Random random = new Random();

            int[] num = new int[10];

            int temp;

            //Заполнение рандомными числами массив 
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = random.Next(Deapason1,Deapason2);
            }
            //Сортируем массив
            for (int i = 0; i < num.Length - 1; i++)
            {
                for (int j = i + 1; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            string s = "";
            //Выводим отсортированный массив
            for (int i = 0; i < num.Length; i++)
            {
                s += (num[i] + ",");
            }
            s = s.Remove(s.Length - 1);
            Console.Write(s);
            //Делаем ожидание нажатие клавиши чтоб консоль сразу не закрывалась 
            Console.ReadLine();
        }
    }
    }
        


