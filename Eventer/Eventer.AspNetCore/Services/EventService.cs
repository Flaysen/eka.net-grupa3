using Eventer.Domain;
using Eventer.Domain.Models;
using Eventer.Domain.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventer.AspNetCore.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository<Event> _repository;

        public EventService(IRepository<Event> repository)
        {
            _repository = repository;
        }

        public void AddEvent(AddEventDto addEventDto)
        {
            Event @event = new Event()
            {
                Id = addEventDto.Id,
                Name = addEventDto.Name,
                StartTime = addEventDto.StartTime,
                EndTime = addEventDto.EndTime,
                ParticipantsNumber = addEventDto.ParticipantsNumber
            };
            _repository.Add(@event);
        }

        public void DeleteEvent(int id)
        {
            _repository.Delete(id);
        }

        public GetEventDto GetEvent(int id)
        {
            IEnumerable<Event> events = _repository.Get();
            var @event = events.FirstOrDefault(x => x.Id == id);
            if (@event != null)
            {

                var getEventDto = new GetEventDto()
                {
                    Id = @event.Id,
                    Name = @event.Name,
                    StartTime = @event.StartTime,
                    EndTime = @event.EndTime,
                    ParticipantsNumber = @event.ParticipantsNumber
                };

                return getEventDto;
            }

            return null;
        }

        public IEnumerable<GetEventDto> GetEvents()
        {
            IEnumerable<Event> events = _repository.Get();
            var getEventDto = new List<GetEventDto>();
            getEventDto = events.Select(x => new GetEventDto()
            {
                Id = x.Id,
                Name = x.Name,
                StartTime = x.StartTime,
                EndTime = x.EndTime,
                ParticipantsNumber = x.ParticipantsNumber
            }).ToList();

            return getEventDto;
        }

        public void UpdateEvent(UpdateEventDto updateEventDto)
        {
            Event @event = new Event()
            {
                Id = updateEventDto.Id,
                Name = updateEventDto.Name,
                StartTime = updateEventDto.StartTime,
                EndTime = updateEventDto.EndTime,
                ParticipantsNumber = updateEventDto.ParticipantsNumber
            };
            _repository.Update(@event);
        }
    }
}
