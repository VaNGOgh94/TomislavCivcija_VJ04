using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTO_aplikacija {

	public partial class FrmLOTO : Form {
		private Loto loto;
		public FrmLOTO() {
			InitializeComponent();
			loto = new Loto();
		}
		

		private void btnUplati_Click(object sender, EventArgs e) {
			List<string> unosi = new List<string>();

			unosi.Add(txtUplaceniBroj1.Text);
			unosi.Add(txtUplaceniBroj2.Text);
			unosi.Add(txtUplaceniBroj3.Text);
			unosi.Add(txtUplaceniBroj4.Text);
			unosi.Add(txtUplaceniBroj5.Text);
			unosi.Add(txtUplaceniBroj6.Text);
			unosi.Add(txtUplaceniBroj7.Text);

			bool ispravanUnos = loto.UnesiUplaceneBrojeve(unosi);
			if (ispravanUnos == true)
				btnOdigraj.Enabled = true;
			else {
				btnOdigraj.Enabled = false;
				MessageBox.Show("Pogrešan unos! Unešena kombinacija mora sadržavati samo različite brojeve");
			}

		}

		private void btnUplati_Enter(object sender, EventArgs e) {
			btnUplati.BackColor = SystemColors.HotTrack;
			btnUplati.Text = "hehe";
        }

		private void btnUplati_Leave(object sender, EventArgs e) {
			btnUplati.BackColor = SystemColors.Control;
			btnUplati.Text = "Uplati";
		}

		private void btnOdigraj_Click(object sender, EventArgs e) {
			loto.GenerirajDobitnuKombinaciju();
			txtDobitniBroj1.Text = loto.DobitniBrojevi[0].ToString();
			txtDobitniBroj2.Text = loto.DobitniBrojevi[1].ToString();
			txtDobitniBroj3.Text = loto.DobitniBrojevi[2].ToString();
			txtDobitniBroj4.Text = loto.DobitniBrojevi[3].ToString();
			txtDobitniBroj5.Text = loto.DobitniBrojevi[4].ToString();
			txtDobitniBroj6.Text = loto.DobitniBrojevi[5].ToString();
			txtDobitniBroj7.Text = loto.DobitniBrojevi[6].ToString();

			int brojLotoPogodaka = loto.IzracunajBrojPogodaka();
			lblBrojPogodaka.Text = brojLotoPogodaka.ToString();
		}

		

		
	}
}
