using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerkiezingRegelaar.Entities;

namespace VerkiezingRegelaar.Repositories.VerkiezingRepo
{
    public class VerkiezingRepo : IVerkiezingRepo
    {
        IConnection connection;
        public VerkiezingRepo()
        {
            this.connection = new Connection();
        }
        public List<Partij> getPartijen(int id)
        {
            throw new NotImplementedException();
        }

        public List<Verkiezing> getVerkiezingen()
        {
            throw new NotImplementedException();
        }
    }
}
