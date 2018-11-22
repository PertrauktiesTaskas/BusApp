namespace BusApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BusDataHandler.BusDataHandler bh = new BusDataHandler.BusDataHandler(@"C:\Users\lukas\source\repos\BusApp\data.txt");
            bh.ParseStops();
        }
    }
}
