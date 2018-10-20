using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistrationSystem.Models
{
    public interface IEventsRepository
    {
        IEnumerable<EventModels> Events { get; }
    }
}
