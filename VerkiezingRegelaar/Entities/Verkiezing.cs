using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkiezingRegelaar.Entities
{
    public class Verkiezing
    {
        private int id;
        private string naam;
        private int zetels;

        public Verkiezing(int id, string naam, int zetels)
        {
            this.id = id;
            this.naam = naam;
            this.zetels = zetels;
        }
        public int getID()
        {
            return id;
        }

        public string getNaam()
        {
            return naam;
        }

        public int getZetels()
        {
            return zetels;
        }
    }
}
