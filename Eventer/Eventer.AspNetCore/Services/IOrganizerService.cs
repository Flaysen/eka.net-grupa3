using System;
using System.Collections.Generic;
using System.Text;
using Eventer.Domain.Models.Dtos;

namespace Eventer.AspNetCore.Services
{
    public interface IOrganizerService
    {
        void AddOrganizer(AddOrganizerDto addOrganizerDto);

        IEnumerable<GetOrganizerDto> GetOrganizers();

        GetOrganizerDto GetOrganizer(int id);

        void DeleteOrganizer(int id);

        void UpdateOrganizer(UpdateOrganizerDto updateOrganizerDto);
    }
}
