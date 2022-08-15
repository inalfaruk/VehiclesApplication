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
    public class BusManager : IBusService
    {
        IBusDal _busdal;

        public BusManager(IBusDal busdal)
        {
            _busdal = busdal;
        }

        public List<Bus> GetAll()
        {
           return _busdal.GetAll();
        }

        public List<Bus> GetAllByColorName(string colorName)
        {
            return _busdal.GetAll().Where(c => c.ColorName == colorName).ToList();
        }

      
    }
}
