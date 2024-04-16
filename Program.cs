internal class Program
{
    private static void Main(string[] args)
    {
        Monster mon = new Monster(1,2);
        if(mon is Monster)
        {
            Console.WriteLine("Gia tri la {0}", mon.attack);
            Console.WriteLine("Gia tri la {0}", mon.health);
            mon.SetColor();
        }
    }
}