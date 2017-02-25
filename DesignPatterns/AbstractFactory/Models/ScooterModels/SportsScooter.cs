using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.ScooterModels
{
    public class SportsScooter : IScooter
    {
        public string Name()
        {
            throw new NotImplementedException();
        }
    }
}
