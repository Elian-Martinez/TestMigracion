using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Migracion_.Models;

namespace Test_Migracion_.Models
{
    public class Equipment
    {
        public int EquipmentId;
        public Person PersonId;
        public Requests RequestsId;
        public DateTime CreationDate;

    }
}
