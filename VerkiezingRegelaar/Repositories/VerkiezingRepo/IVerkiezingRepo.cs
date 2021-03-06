﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VerkiezingRegelaar.Entities;

namespace VerkiezingRegelaar.Repositories.VerkiezingRepo
{
    public interface IVerkiezingRepo
    {
        List<Verkiezing> getVerkiezingen();
        List<Partij> getPartijen(int id);
        List<Partij> getAllPartijen();
        void addVerkiezing(List<int> partijIDs, string text, int value);
        //List<Uitslag> getUitslagen(int id);
        //List<Coalitie> getCoalities(int id);
    }
}
