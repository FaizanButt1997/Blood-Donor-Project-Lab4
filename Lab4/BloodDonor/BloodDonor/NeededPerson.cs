using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonor
{
    public class NeededPerson
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BloodGroup { get; set; }

        public string CellNumber { get; set; }

        public int Age { get; set; }

        public Egender Egender { get; set; }
        public DateTime TakenBloodDate { get; set; }
        public int TakenCounter { get; set; }


    }
}
