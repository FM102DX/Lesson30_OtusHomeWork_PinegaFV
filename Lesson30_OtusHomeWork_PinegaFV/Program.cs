using System;

namespace Lesson30_OtusHomeWork_PinegaFV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Workshop workshop1 = new Workshop("Мастерская 1", 2, 1,2000, 3000, 5000);
            Workshop workshop2 = workshop1.MyClone();

            workshop2.ShieldTitle = "Мастерская 2";
            workshop2.NumberOfDoors = 2;
            workshop2.NumberOfWindows= 3;
            
            Workshop workshop3 = (Workshop) workshop1.Clone();
            workshop3.ShieldTitle = "Мастерская 3";
            workshop3.NumberOfDoors = 1;
            workshop3.NumberOfWindows = 4;

            Workshop workshop4 = (Workshop)workshop1.Clone();
            workshop4.ShieldTitle = "Мастерская 4";
            workshop4.NumberOfDoors = 2;
            workshop4.NumberOfWindows = 6;

            Console.WriteLine("Демонстрация паттерна Прототип");
            Console.WriteLine("");
            Console.WriteLine("Исходный объект");
            Console.WriteLine(workshop1.ToString());
            Console.WriteLine("");
            Console.WriteLine("Демонстрация собственного интерфейса IMyCloneable");
            Console.WriteLine(workshop2.ToString());
            Console.WriteLine("");
            Console.WriteLine("Демонстрация интерфейса ICloneable");
            Console.WriteLine(workshop3.ToString());
            Console.WriteLine(workshop4.ToString());

        }
    }
}
