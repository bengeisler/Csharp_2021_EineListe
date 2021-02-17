using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

		private void btnSpeichern_Click(object sender, EventArgs e)
		{
			// Filestream-Objekt erstellen
			FileStream fs = new FileStream("liste.txt", FileMode.Append);

			// StreamWriter-Objekt erstellen
			StreamWriter sw = new StreamWriter(fs);

			// Jedes Element der Liste einzeln in die Datei schreiben
			foreach (var item in lstListe.Items)
			{
				sw.WriteLine(item);
			}

			sw.Close();
		}

		private void btnLaden_Click(object sender, EventArgs e)
		{
			// FileStream-Objekt erstellen
			FileStream fs = new FileStream("list.txt", FileMode.Open);

			// StreamReader-Objekt erstellen
			StreamReader sr = new StreamReader(fs);

			string zeile;

			// Datei Zeile für Zeile auslesen und jede Zeile
			// als Item der Liste hinzufügen
			while (sr.Peek() != -1)
			{
				zeile = sr.ReadLine();
				lstListe.Items.Add(zeile);
			}

			// StreamReader schließen
			sr.Close();
		}
	}
}
