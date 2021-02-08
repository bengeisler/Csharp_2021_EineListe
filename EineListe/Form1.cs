using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EineListe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnHinzufügen_Click(object sender, EventArgs e)
		{
			lstListe.Items.Add(txtStadt.Text);
			txtStadt.Text = "";
		}

		private void btnLöschen_Click(object sender, EventArgs e)
		{
			lstListe.Items.Remove(lstListe.SelectedItem);
		}

		private void btnAlleLöschen_Click(object sender, EventArgs e)
		{
			lstListe.Items.Clear();
		}

		private void btnBeenden_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
