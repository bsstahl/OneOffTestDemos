﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bss.StarWars
{
    public interface IPlanetRepository
    {
        IEnumerable<Planet> GetAllPlanets();
    }
}
