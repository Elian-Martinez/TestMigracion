using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Migracion_.Models;

namespace Test_Migracion_.Services.Contracts
{
    public interface IPersonService
    {
        Person AddPerson(Person person);

    }
}
