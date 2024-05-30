﻿using Models;
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

        public bool Update(int id)
        {
            return _repository.Update(id);
        }

        public bool Delete(int id)
        {
               return _repository.Delete(id);
        }
        public Car Get(int id) 
        {
            return _repository.Get(id);
        }

        public List<Car> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
