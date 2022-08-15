using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BoatDal :IBoatDal
    {

        List<Boat> _boats;

        public BoatDal()
        {
            _boats = new List<Boat>
            {
                new Boat{ColorName="red",},
                new Boat{ColorName="black"},
                new Boat{ColorName="white"},
                new Boat{ColorName="blue"},
                new Boat{ColorName="white"},
                new Boat{ColorName="black"},


            };
        }


        public List<Boat> GetAll()
        {
            return _boats;
        }
    }
}
