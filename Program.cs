// Jeremy Gallen's sample program to demonstrate inheritance

// Overall namespace
namespace Inheritance
{
    // Vehicle class
    class Vehicle
    {
        // Brand name
        public string brand = "Honda";

        // Horn method
        public void horn()
        {
            Console.WriteLine("Honk!");
        }
    }

    // Derived class
    class Compact : Vehicle
    {
        // Model name
        public string model = "Fit";
    }

    // Main class
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create compact car object
            Compact myCar = new Compact();

            // Call horn
            myCar.horn();

            // Display brand and model
            Console.WriteLine(myCar.brand + " " + myCar.model);
        }
    }
}