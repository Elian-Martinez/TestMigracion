using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Migracion_.Models
{
    public class PersonViewModel
    {
        public List<Person> Persons { get; set; }
        public Person Person { get; set; }
        public Requests Request { get; set; }

        public PersonViewModel()
        {
            Persons = new List<Person>();
        }
    }
}
