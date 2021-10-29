using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Migracion_.Models;
using Test_Migracion_.Services.Contracts;

namespace Test_Migracion_.Services
{
    public class PersonService : IPersonService
    {
        private readonly AplicationDbContext _aplicationDbContext;

        public PersonService(AplicationDbContext aplicationDbContext)
        {
            this._aplicationDbContext = aplicationDbContext;
        }
        public Person AddPerson(Person person)
        {
            _aplicationDbContext.Person.Add(person);
            _aplicationDbContext.Requests.AddRange(person.Requests.ToArray());
            _aplicationDbContext.SaveChanges();
            return person;
        }
    }
}
