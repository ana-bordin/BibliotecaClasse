using Controllers;
using Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 1000; i++)
            //{
            //    car.Name = "Teste - " + i.ToString(); 

            //    Console.WriteLine(new CarController().Insert(car) ? "Carro inserido com sucesso" + car.Name : "Falha ao inserir carro");
            //}


            foreach (var item in new CarController().GetAll().Where(x => x.Id > 990).ToList().Take(10))
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(new CarController().Update(car) ? "Carro atualizado com sucesso" : "Falha ao atualizar carro");

            //Console.WriteLine(new CarController().Delete(car.Id) ? "Carro deletado com sucesso" : "Falha ao deletar carro");


            //Console.WriteLine(new CarController().Get(3));
            

            //List<Car> listCar = new CarController().GetAll();

            //foreach (var item in listCar)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine();
        }
    }
}
