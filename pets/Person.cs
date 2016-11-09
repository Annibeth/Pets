using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Person
    {
        public String name;
        public int birthYear;
        public Specie specieName;

        public Person(String name, int birthYear, Specie specieName)
        {
            this.name       = name;
            this.birthYear  = birthYear;
            this.specieName = specieName;
        }
    }
}

