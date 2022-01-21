using System;

namespace Facade
{
    public class CdPlayer
    {
        public void On()
        {
            Console.WriteLine("CD плеер включён");
        }

        public void Off()
        {
            Console.WriteLine("CD плеер выключен");
        }

        public void Eject()
        {
            Console.WriteLine("Диск извлечён");
        }

        public void Pause()
        {
            Console.WriteLine("Пауза");
        }

        public void Play(string name)
        {
            Console.WriteLine($"Сейчас играет: {name}");
        }

        public void Stop()
        {
            Console.WriteLine("Стоп");
        }
    }
}
