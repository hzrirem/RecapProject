using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
             new Car{ Id=1, BrandId=1, ColorId=1, ModelYear=1976, DailyPrice=150, Description="Sorunsuz"},
             new Car{ Id=2, BrandId=5, ColorId=16, ModelYear=2015, DailyPrice=250, Description="Sorunsuz" },
             new Car{ Id=3, BrandId=7, ColorId=14, ModelYear=2021, DailyPrice=500, Description="Sorunsuz" },
             new Car{ Id=4, BrandId=9, ColorId=8, ModelYear=2011, DailyPrice=200, Description="Sorunsuz"},
             new Car{ Id=5, BrandId=12, ColorId=17, ModelYear=2002, DailyPrice=175, Description="Sorunsuz"}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;

            carToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;

        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
