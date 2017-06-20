using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkiezingRegelaar.Entities
{
    public class Partij
    {
        private int id;
        private string naam;
        private string lijsttrekker;

        public Partij(int id, string naam, string lijsttrekker)
        {
            this.id = id;
            this.naam = naam;
            this.lijsttrekker = lijsttrekker;
        }
        public int getID()
        {
            return id;
        }

        public string getNaam()
        {
            return naam;
        }

        public void setNaam(string naam)
        {
            this.naam = naam;
        }
        public string getLijsttrekker()
        {
            return lijsttrekker;
        }
        public void setLijsttrekker(string lijsttrekker)
        {
            this.lijsttrekker = lijsttrekker;
        }
    }
}
