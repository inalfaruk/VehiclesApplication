using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;
        string keyString;
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;
        }

        public string DeleteByCarId(Car car)
        {
            _cardal.Delete(car);
            return $"Car number of deleted {car.Id}";
        }

        public List<Car> GetAll()
        {
           return _cardal.GetAll();
        }

        public List<Car> GetAllByColorName(string colorName)
        {
            return _cardal.GetAll().Where(c=>c.ColorName==colorName).ToList();
        }

        public string HeadLightSwitch(int id, bool key)
        {
            _cardal.HeadLightsSwitch(id, key);

            if (key == true)

                keyString = "on";
            else
                keyString = "off";


            return $"Car number {id} headlights are {keyString} ";
        }
    }
}
