using Console = System.Console;

namespace PartialClassExample
{
    partial class Car
    {
        public void Start()
        {
            Console.WriteLine("Arac calistirildi.");
        }

        public void StopEngine()
        {
            if (this.speed != 0)
            {
                Console.WriteLine("Hareket halinde motor stop edilemez.");
            }
            else
            {
                Console.WriteLine("Arac stop edildi.");
            }
            
        }

        public void Accelerate(int amount)
        {
            this.Speed += amount;
            Console.WriteLine($"Hiziniz {amount} KM yukseltildi.");
        }

        public void SlowDown(int amount)
        {
            this.Speed -= Math.Max(0, amount);
            Console.WriteLine($"Hiziniz {amount} KM dusuruldu.");
        }

        public void Stop()
        {
            this.Speed = 0;
            Console.WriteLine("Arac durduruldu.");
        }
    }
}
