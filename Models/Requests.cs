using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test_Migracion_.Models
{
    public class Requests
    {
            public int RequestsId { get; set; }
            public String RequestsName { get; set; }
            public String RequestsEstate { get; set; }
            public DateTime RequestsCreation { get; set; }
            public Person Person { get; set; }
            public Equipment Equipment { get; set; }
            public int PersonId { get; set; }
    }
}
