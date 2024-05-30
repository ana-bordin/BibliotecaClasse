using Models;

namespace Repositories
{
    public class CarRepository
    {
        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Repositories");
            return true;
        }

    }
}
