using Models;
using System.ComponentModel.DataAnnotations;

namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Car car = new Car
            {
                Id = 1,
                Name = "Carro Legal",
                Color = "Azul",
                Year = 1970
            };
            Console.WriteLine(car);
        }
    }
}
