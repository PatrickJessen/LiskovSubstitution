using System;

namespace LiskovSubstitution
{
    class Program
    {
        static FlyingBird eagle;
        static Bird penguin;
        static void Main(string[] args)
        {
            eagle = new Eagle("Eagle", 10, 20, 0);
            penguin = new Bird("Penguin", 10, 20);
            List<Pattern> pattern = new List<Pattern>() { new Pattern(1, 3), new Pattern(2, 5), new Pattern(6, 2), new Pattern(3, 6) };
            List<Pattern> flyPattern = new List<Pattern>() { new FlyPattern(1, 3, 1), new FlyPattern(2, 5, 3), new FlyPattern(6, 2, 5), new FlyPattern(3, 6, 5) };
            penguin.SetPattern(pattern);
            eagle.SetPattern(flyPattern);
            Thread t = new Thread(eagle.Fly);
            Thread t1 = new Thread(penguin.Move);
            Thread t2 = new Thread(Draw);
            t.Start();
            t1.Start();
            t2.Start();
        }

        static void Draw()
        {
            while (true)
            {
                Console.WriteLine(eagle.Draw());
                Thread.Sleep(500);
                Console.WriteLine(penguin.Draw());
            }
        }
    }
}