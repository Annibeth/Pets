using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public Specie specieName;
        public String petName;

        public Pet(Specie specieName, String petName)
        {
            this.specieName = specieName;
            this.petName = petName;
        }
    }
}
