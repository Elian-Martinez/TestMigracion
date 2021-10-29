using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Migracion_.Models;

namespace Test_Migracion_.Models
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public Requests Requests { get; set; }
        public int RequestsId { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
