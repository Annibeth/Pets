using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    class Specie
    {
        private string name;
        private int numberOfEys;
        private int numberOfLegs;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int NumberOfEys
        {
            get
            {
                return numberOfEys;
            }
        }
        public int NumberOfLegs
        {
            get
            {
                return numberOfLegs;
            }
        }




        public Specie(string name, int numberOfEys, int numberOfLegs)
        {
            this.name = name;
            this.numberOfEys = numberOfEys;
            this.numberOfEys = numberOfLegs;


        }

    }
    
    

}
