using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Person
    {
        private string name;
        private int birthYear;
        private Pet specieName;

        public string Name
        {
            get
            {
              return name;
            }
        }
        public int BirthYear
        {
            get
            {
                return birthYear;
            }
        }
        public Pet SpecieName
        {
            get
            {
                return specieName;
            }
        }


        public Person(String name, int birthYear, Pet specieName)
        {
            this.name       = name;
            this.birthYear  = birthYear;
            this.specieName = specieName;
        }
    }
}

