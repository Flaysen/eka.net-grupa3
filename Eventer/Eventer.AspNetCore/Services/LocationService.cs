using System;
using Eventer.Domain.Models.Dtos;
using Eventer.Domain;
using Eventer.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventer.AspNetCore.Services
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> _locationrepository;

        public LocationService(IRepository<Location> locationrepository)
        {
            _locationrepository = locationrepository;
        }
        public void AddLocation(AddLocationDto addLocationDto)
        {
            Location @location = new Location()
            {
                Id = addLocationDto.Id,
                Country = addLocationDto.Country,
                City = addLocationDto.City,
                Street = addLocationDto.Street,
                HouseNumber = addLocationDto.HouseNumber,
                FlatNumber = addLocationDto.FlatNumber
            };
            _locationrepository.Add(@location);
        }

        public void DeleteLocation(int id)
        {
            _locationrepository.Delete(id);
        }

        public GetLocationDto GetLocation(int id)
        {
            IEnumerable<Location> locations = _locationrepository.Get();
            var @location = locations.FirstOrDefault(x => x.Id == id);
            if (@location != null)
            {
                var getLocationDto = new GetLocationDto()
                {
                    Id = location.Id,
                    Country = location.Country,
                    City = location.City,
                    Street = location.Street,
                    HouseNumber = location.HouseNumber,
                    FlatNumber = location.FlatNumber
                };
                return getLocationDto;
            }
            return null;
        }

        public IEnumerable<GetLocationDto> GetLocations()
        {
            IEnumerable<Location> locations = _locationrepository.Get();
            var getLocationsDto = new List<GetLocationDto>();
            getLocationsDto = locations.Select(x => new GetLocationDto()
            {
                Id = x.Id,
                Country = x.Country,
                City = x.City,
                Street = x.Street,
                HouseNumber = x.HouseNumber,
                FlatNumber = x.FlatNumber
            }).ToList();

            return getLocationsDto;
        }

        public void UpdateLocation(UpdateLocationDto updateLocationDto)
        {
            Location @location = new Location()
            {
                Id = updateLocationDto.Id,
                Country = updateLocationDto.Country,
                City = updateLocationDto.City,
                Street = updateLocationDto.Street,
                HouseNumber = updateLocationDto.HouseNumber,
                FlatNumber = updateLocationDto.FlatNumber
            };
            _locationrepository.Update(@location);
        }
    }
}
