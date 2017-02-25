using AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Models.BikeModels
{
    public class SportsBike : IBike
    {
        public string Name()
        {
            throw new NotImplementedException();
        }
    }
}
