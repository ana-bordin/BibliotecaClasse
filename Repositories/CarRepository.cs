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
        
        public bool Update(int id)
        {
            return true;
        }
        
        public bool Delete(int id)
        {
            return true;
        }
        
        public Car Get(int id)
        {
            return new Car();
        }
        
        public List<Car> GetAll()
        {
            return new List<Car>();
        }
    }
}
