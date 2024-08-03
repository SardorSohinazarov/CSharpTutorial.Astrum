using CRUD.Models;
using CRUD.Services.Base;

namespace CRUD.Services.Persons
{
    internal class PersonService : GenericCRUDService<Person>, IPersonService
    {
        public PersonService()
        {
        }
    }
}
