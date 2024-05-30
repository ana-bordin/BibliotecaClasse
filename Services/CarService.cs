using Models;
using Repositories;

namespace Services
{
    public class CarService
    {
        private CarRepository _repository;

        public CarService()
        {
            _repository = new CarRepository();
        }
        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Service");
            return _repository.Insert(car);
        }
    }
}
