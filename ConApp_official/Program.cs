using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_24;

namespace ConApp_official
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create instances of Source and Destination classes
            Source source = new Source { Id = 1, Name = "Product", Price = 29.99, Description = "Package Details" };
            Destination destination = new Destination();

            // Call MapProperties method to map properties
            PropertyMapper.MapProperties(source, destination);

            // Display the values in the Destination class
            Console.WriteLine($"Destination Id: {destination.Id}");
            Console.WriteLine($"Destination Name: {destination.Name}");
            Console.WriteLine($"Destination Price: {destination.Price}");
            Console.WriteLine($"Destination Description: {destination.Description}");

            Console.ReadLine();
        }
    }
}
