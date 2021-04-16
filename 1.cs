
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    struct NOTE
    {
        public int Number;
        public string Name;
        public string NumberOfPhone;
        public int treenumberofphone;
        public int[] DataOfBorn;
    }
    class Program
    {
        static NOTE[] BubbleSort(NOTE[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {

                for (int j = 0; j < mas.Length - 1 - i; j++)
                {
                    if (mas[j].treenumberofphone > mas[j + 1].treenumberofphone)
                    {
                        NOTE tmp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = tmp;
                    }
                }
            }
            return mas;
        }

        static void EnterInfo(NOTE[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {

                Console.WriteLine("Пользователь " + (mas[i].Number = i + 1) + " :");

                Console.Write("Фамилия Имя : " + mas[i].Name);
                mas[i].Name = Console.ReadLine();
                //Console.Write("Введите первые три цифры номер телефона: ");
                // = Convert.ToInt32(Console.ReadLine());
                Console.Write("Номер телефона: ");
                int numbers = Convert.ToInt32(Console.ReadLine());
                mas[i].treenumberofphone = numbers / 1000000;
                mas[i].NumberOfPhone = String.Format("{0:+375 (##) ###-##-##}", numbers);
                Console.Write("Дата рождения(день) : " + mas[i].DataOfBorn);
                mas[i].DataOfBorn = new int[3];
                int j = 0;
                mas[i].DataOfBorn[j] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("месяц");
                mas[i].DataOfBorn[j + 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("год");
                mas[i].DataOfBorn[j + 2] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void OutPutInfo(NOTE[] mas)
        {
            Console.Clear();
            BubbleSort(mas);
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"\nПользователь: {mas[i].Number }\nФамилия Имя :{ mas[i].Name }\nНомер телефона : {mas[i].NumberOfPhone}");
                for (int j = 0; j < mas[i].DataOfBorn.Length; j++)
                {
                    Console.WriteLine("Дата рождения : " + mas[i].DataOfBorn[j]);
                }
            }
        }

        static void SearchOnePerson(NOTE[] mas, string searchname)
        {
            int kof = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (searchname == mas[i].Name)
                {
                    Console.WriteLine($"\nПользователь: {mas[i].Number }\nФамилия Имя :{ mas[i].Name }\nНомер телефона : {mas[i].NumberOfPhone}");
                    for (int j = 0; j < mas[i].DataOfBorn.Length; j++)
                    {
                        Console.WriteLine("Дата рождения : " + mas[i].DataOfBorn[j]);
                    }
                    kof++;
                }
            }
            if (kof == 0)
                Console.WriteLine("Такого человека в списке нет!");
        }

        static void Main(string[] args)
        {
            NOTE[] user = new NOTE[8];
            EnterInfo(user);
            OutPutInfo(user);
            bool Exit = false;
            while (!Exit)
            {
                Console.Write("Введите имя человека: ");
                string searchname = Console.ReadLine();
                SearchOnePerson(user, searchname);
                Console.Write("Хотите продолжить?\n[1-Да,2-Нет]:  ");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose != 1)
                    Exit = true;

            }

        }


    }

}


/*
Егор
334876758
23
10
2002
Коля
297405680
10
10
1998
Андрей
447890987
05
03
2000
Станислав
295673409
26
06
2001
Алеша
297657845
10
10
2005
Вася
447654323
19
10
2000
Вова
338765343
17
08
2000
Гена
292000023
16
08
1973
*/