using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CarDal : ICarDal
    {
        List<Car> _cars;

        public CarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,ColorName="red",Headlights=true ,Wheels ="4 seasons"},
                new Car{Id=2,ColorName="black",Headlights=true ,Wheels ="Snow tire"},
                new Car{Id=3,ColorName="white",Headlights=false ,Wheels ="Snow tire"},
                new Car{Id=4,ColorName="blue",Headlights=false ,Wheels ="Snow tire"},

            };
        } 

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void HeadLightsSwitch(int id, bool key)
        {
            string keyString;
             _cars.SingleOrDefault(c=>c.Id==id).Headlights=key;

           
            
        }
    }
}
