using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using EventRegistrationSystem.Models;

namespace EventRegistrationSystem.Abstract
{
    public interface IEventRepository
    {
        
        IEnumerable<Event> Events { get; }
    }

}
