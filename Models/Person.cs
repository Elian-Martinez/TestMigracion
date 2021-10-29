using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Migracion_.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string PersonLastName { get; set; }
        public DateTime PersonOfBirth { get; set; }
        public int PersonPassport { get; set; }
        public string PersonAdress { get; set; }
        public string PersonGender { get; set; }
        public byte[] PersonPhoto { get; set; }
    }
}
