using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bss.StarWars.Entities;

namespace Bss.StarWars.Data
{
    public class PlanetRepository : Bss.StarWars.IPlanetRepository
    {

        // Finds all planets that meet your
        // minimum standards for residence
        //public IEnumerable<Planet> Scout(SpeciesName species)
        //{
        //    return _planetRepository.GetAll();
        //}

        //// Recommends the best planet for you
        //public Planet Recommend()
        //{
        //    throw new NotImplementedException();
        //}

        //internal static int Score(Planet planet)
        //{
        //    throw new NotImplementedException();
        //}

        //internal static bool MeetsMinimumStandards(Planet planet)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<Planet> GetAllPlanets()
        {
            throw new NotImplementedException();
        }
    }
}
