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
    public partial class NieuwVerkiezing : Form
    {
        IVerkiezingRepo VerkiezingRepo;
        public NieuwVerkiezing()
        {
            InitializeComponent();
            VerkiezingRepo = new VerkiezingRepo();
            loadPartijen();
        }

        private void loadPartijen()
        {
            foreach (Partij partij in VerkiezingRepo.getAllPartijen())
            {
                checkedListBoxPartijen.Items.Add(partij.getNaam() + " Lijsttrekker: " + partij.getLijsttrekker());
            }
        }

        private void buttonToevoegen_Click(object sender, EventArgs e)
        {
            if (checkedListBoxPartijen.CheckedItems.Count > 0 && textBoxNaam.Text != "")
            {
                List<int> partijIDs = new List<int>();
                foreach (Partij partij in VerkiezingRepo.getAllPartijen())
                {
                    if (checkedListBoxPartijen.CheckedItems.Contains(partij.getNaam() + " Lijsttrekker: " + partij.getLijsttrekker()))
                    {
                        partijIDs.Add(partij.getID());
                    }
                }
                VerkiezingRepo.addVerkiezing(partijIDs, textBoxNaam.Text, Convert.ToInt16(numericUpDownZetels.Value));
            }
            else
            {
                MessageBox.Show("Selecteer partijen en/of vul een naam in.");
            }
            Close();
        }

        private void buttonAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
