using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerkiezingRegelaar.Entities;
using VerkiezingRegelaar.Repositories.VerkiezingRepo;

namespace VerkiezingRegelaar
{
    public partial class Verkiezingen : Form
    {
        IVerkiezingRepo verkiezingRepo;
        public Verkiezingen()
        {
            InitializeComponent();
            verkiezingRepo = new VerkiezingRepo();
            loadVerkiezingen();
        }

        private void loadVerkiezingen()
        {
            foreach (Verkiezing verkiezing in verkiezingRepo.getVerkiezingen())
            {
                listBoxVerkiezingen.Items.Add(verkiezing.getNaam());
            }
        }

        private void ButtonOpenen_Click(object sender, EventArgs e)
        {

        }

        private void buttonNieuw_Click(object sender, EventArgs e)
        {
            NieuwVerkiezing nieuw = new NieuwVerkiezing();
            nieuw.ShowDialog();
        }
    }
}
