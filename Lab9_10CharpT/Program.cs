namespace Lab9_10CharpT
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Task1");
            ReverseCheck reverseCheck = new ReverseCheck();
            reverseCheck.Run();

            Console.WriteLine("\nTask2\n");
            PositiveNegativeOrder pnOrder = new PositiveNegativeOrder();
            pnOrder.Run();
        }
    }
}
