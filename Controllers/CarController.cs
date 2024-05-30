using Models;
using Services;

namespace Controllers
{
    public class CarController
    {
        private CarService _carService;

        public CarController() 
        {
            _carService = new CarService();
        }

        public bool Insert(Car car)
        {
            Console.WriteLine("Camada Controller");
            return true;
        }
    }
}
