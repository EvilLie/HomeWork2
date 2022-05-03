using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не влезало в строку так что решил переделать
            //string Surname = "Конев ", Name = "Иван ", Patronymic = "Алексеевич", Email = "AlexHorse@gmail.com", FullName = Surname + Name + Patronymic;
            //byte Age = 19;
            //float Prog = 7.8f, Math = 8.2f, Phys = 6.9f;
            //Console.WriteLine($" ФИО:{FullName}\n Возраст:{Age}\n Email:{Email}\n Оценки:\n по программированию:{Prog:#.##}\n по математике:{Math:#.##}\n по физике:{Phys:#.##}");
            //Console.ReadKey();
            string Surname = "Конев ", Name = "Иван ", Patronymic = "Алексеевич", Email = "AlexHorse@gmail.com", FullName = Surname + Name + Patronymic; ;
            byte Age = 19;
            float Prog = 7.8f, Math = 8.2f, Phys = 6.9f;
            string Pattern = " ФИО: {0} Возраст:{1}\n Email:{2}\n Оценки\n по программированию:{3}\n по математике:{4}\n по физике:{5} ";
            Console.WriteLine(Pattern, FullName, Age, Email, Prog, Math, Phys);
            Console.ReadKey();
            Console.WriteLine(" Second Part of homework\n");
            float Sum = Prog + Math + Phys, Average = Sum / 3;
            Console.WriteLine($" Сумма баллов:{Sum}\n Средний балл:{Average.ToString("#.###")}");
            Console.ReadKey();
        }
    }
}
