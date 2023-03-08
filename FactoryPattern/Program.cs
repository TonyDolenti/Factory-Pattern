namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool input = false;
            int wheelCount;
            do
            {
                Console.WriteLine("Enter the amount of wheels you want your vehicle to have, either 2 or 4!");

                

                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (input == false);

            
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
