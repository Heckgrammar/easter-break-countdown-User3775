namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                DateTime rightnow = DateTime.Now;
                DateTime target = new DateTime(2025, 4, 4, 15, 15, 0);
                TimeSpan timeleft = target - rightnow;
                Console.WriteLine(timeleft);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
