namespace MotorVehicles.IO
{
    using MotorVehicles.IO.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
