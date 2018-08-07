using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonor
{
    public class Person
    {
        public Person()
        {
            Id = 0;
            Name = null;
            PhoneNumber = null;
            FatherName = null;
            CNIC = null;
            GivenCounter = 0;
            BloodGroup = null;

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }
        public string FatherName { get; set; }

        public DateTime dateTimeOfGivenBlood { get; set; }
        public string CNIC { get; set; }

        public DateTime DOB { get; set; }

        public int Age { get; set; }

        public Egender Egender { get; set; }
        public DateTime GivenBloodDate { get; set; }
        public int GivenCounter { get; set; }
        public string BloodGroup { get; set; }

    }
}
