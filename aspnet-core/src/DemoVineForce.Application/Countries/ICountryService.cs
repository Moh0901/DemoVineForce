using DemoVineForce.Authorization.Entities;
using DemoVineForce.Countries.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVineForce.Countries
{
    public interface ICountryService
    {
        List<Country> GetAllCountries();

        Country GetCountryById(int id);

        Country AddCountry(CountryDTo country);

        Country UpdateCountry(CountryDTo country, int id);

        Country DeleteCountry(int id);
    }
}
