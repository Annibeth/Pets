using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Pet
    {
        private Specie specieName;
        private String petName;

        public Specie SpecieName
        {
            get
            {
                return specieName;
            }
        }
        public string PetName
        {
            get
            {
                return petName;
            }
        }


        public Pet(Specie specieName, String petName)
        {
            this.specieName = specieName;
            this.petName = petName;
        }
    }
}
