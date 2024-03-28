using Abp.Zero.EntityFrameworkCore;
using DemoVineForce.Authorization.Entities;
using DemoVineForce.Countries.Dto;
using DemoVineForce.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVineForce.Countries
{
    public class CountryService : ICountryService
    {
        private readonly DemoVineForceDbContext _db;

        public CountryService(DemoVineForceDbContext db)
        {
            _db = db;

        }
        public Country AddCountry(CountryDTo country)
        {
           Country newCountry = new Country();

            newCountry.CountryName = country.CountryName;
            
            _db.Countries.Add(newCountry);
            _db.SaveChanges();

            return newCountry;
        }

        public Country DeleteCountry(int id)
        {
            var country = _db.Countries.Find(id);
            if(country == null)
            {
                return null;
            }
            _db.Countries.Remove(country);
            _db.SaveChanges();

            return country;
        }

        public List<Country> GetAllCountries()
        {
            var countryList = _db.Countries.ToList();

            return countryList;
        }

        public Country GetCountryById(int id)
        {
            var country = _db.Countries.FirstOrDefault(c => c.Id == id);

            return country;
        }

        public Country UpdateCountry(CountryDTo country, int id)
        {
           var updateCountry = new Country();
            {
                updateCountry.CountryName = country.CountryName;
            }

            _db.Entry(updateCountry).State = EntityState.Modified;

            _db.SaveChanges();
            return _db.Countries.Find(id);
        }
    }
}
