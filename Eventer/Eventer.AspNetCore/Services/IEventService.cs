
using Eventer.Domain.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eventer.AspNetCore.Services
{
    public interface IEventService
    {
        IEnumerable<GetEventDto> GetEvents();
        GetEventDto GetEvent(int id);
        void AddEvent(AddEventDto addEventDto);
        void UpdateEvent(UpdateEventDto updateEventDto);
        void DeleteEvent(int id);
    }
}
