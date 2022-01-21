using System;

namespace Facade
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Тюнер включён");
        }

        public void Off()
        {
            Console.WriteLine("Тюнер выключен");
        }

        public void SetAm()
        {
            Console.WriteLine("AM установлен");
        }

        public void SetFm()
        {
            Console.WriteLine("Fm установлен");
        }

        public void SetFrequency(int frequency)
        {
            Console.WriteLine($"Выставлена частота {frequency}.");
        }
    }
}
