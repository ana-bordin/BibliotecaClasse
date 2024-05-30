using Microsoft.Data.SqlClient;
using Models;
using System.Text;

namespace Repositories
{
    public class CarRepository
    {
        string strConn = "Server=127.0.0.1; Database=ProjetoAula02; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        SqlConnection conn;

        public CarRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public bool Insert(Car car)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Car.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Update(Car car)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Car.UPDATE, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.Parameters.Add(new SqlParameter("@Id", car.Id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Delete(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Car.DELETE, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                return (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Car> GetAll()
        {
            List<Car> cars = new List<Car>();
            StringBuilder sb = new StringBuilder();  
            sb.Append(Car.GETALL);

            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                    cars.Add(car);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }

        public Car Get(int id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Car.GET);  
            Car car = new Car();
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return car;
        }
    }
}
