using System;
using Eventer.Domain.Models.Dtos;
using System.Collections.Generic;
using System.Text;

namespace Eventer.AspNetCore.Services
{
    public interface ILocationService
    {
        IEnumerable<GetLocationDto> GetLocations();

        GetLocationDto GetLocation(int id);

        void AddLocation(AddLocationDto addLocationDto);

        void UpdateLocation(UpdateLocationDto updateLocationDto);
        void DeleteLocation(int id);
    }
}
