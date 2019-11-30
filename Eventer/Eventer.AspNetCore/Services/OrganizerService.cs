using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Eventer.Domain;
using Eventer.Domain.Models;
using Eventer.Domain.Models.Dtos;

namespace Eventer.AspNetCore.Services
{
    public class OrganizerService : IOrganizerService
    {
        private readonly IRepository<Organizer> _organizerrepository;

        public OrganizerService(IRepository<Organizer> organizerrepository)
        {
            _organizerrepository = organizerrepository;
        }

        public void AddOrganizer(AddOrganizerDto addOrganizerDto)
        {
            Organizer @organizer = new Organizer()
            {
                Id = addOrganizerDto.Id,
                Name = addOrganizerDto.Name,
                LastName = addOrganizerDto.LastName,
                PhoneNumber = addOrganizerDto.PhoneNumber,
                Email = addOrganizerDto.Email,
                CompanyName = addOrganizerDto.CompanyName
                
            };
            _organizerrepository.Add(@organizer);
            
        }

        public void DeleteOrganizer(int id)
        {
            _organizerrepository.Delete(id);
        }

        public GetOrganizerDto GetOrganizer(int id)
        {
            IEnumerable<Organizer> organizers = _organizerrepository.Get();
            var @organizer = organizers.FirstOrDefault(x => x.Id == id);
            if(@organizer != null)
            {
                var getOrganizerDto = new GetOrganizerDto()
                {
                    Id = organizer.Id,
                    Name = organizer.Name,
                    LastName = organizer.LastName,
                    PhoneNumber = organizer.PhoneNumber,
                    Email = organizer.Email,
                    CompanyName = organizer.CompanyName
                };
                return getOrganizerDto;
            }
            return null;
        }

        public IEnumerable<GetOrganizerDto> GetOrganizers()
        {
            IEnumerable<Organizer> organizers = _organizerrepository.Get();
            var getOrganizersDto = new List<GetOrganizerDto>();
            getOrganizersDto = organizers.Select(x => new GetOrganizerDto()
            {
                Id = x.Id,
                Name = x.Name,
                LastName = x.LastName,
                PhoneNumber = x.PhoneNumber,
                Email = x.Email,
                CompanyName = x.CompanyName

            }).ToList();

            return getOrganizersDto;
        }

        public void UpdateOrganizer(UpdateOrganizerDto updateOrganizerDto)
        {
            Organizer @organizer = new Organizer()
            {
                Id = updateOrganizerDto.Id,
                Name = updateOrganizerDto.Name,
                LastName = updateOrganizerDto.LastName,
                PhoneNumber = updateOrganizerDto.PhoneNumber,
                Email = updateOrganizerDto.Email,
                CompanyName = updateOrganizerDto.CompanyName
               
            };
            
            _organizerrepository.Add(@organizer);
        }
    }
}
