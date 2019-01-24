using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistrationSystem.Models
{
    //The Generic Interface Repository for Performing Read/Add/Delete operations
    public interface IRepository<TEnt, in TPk> where TEnt : class
    {
        IEnumerable<TEnt> Get();
        TEnt Get(TPk id);
        void Add(TEnt entity);
        void Remove(TEnt entity);
    }
}

/* The above code is the generic interface which has TEnt and TPk generic type. 
 * TEnt is set with the constraints as class. This interface defines methods for 
 * Read/Write operations. We are implementing this interface as generic interface
 * so that we can use it for all model entities for performing CRUD operations.
 * https://www.dotnetcurry.com/aspnet-mvc/1155/aspnet-mvc-repository-pattern-perform-database-operations
 * */
