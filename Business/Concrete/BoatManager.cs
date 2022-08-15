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
    public class BoatManager : IBoatService 
    {
        IBoatDal _boatDal;

        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }

        public List<Boat> GetAll()
        {
           return _boatDal.GetAll();
           
        }

        public List<Boat> GetAllByColorName(string colorName)
        {
            throw new NotImplementedException();
        }
    }
}
