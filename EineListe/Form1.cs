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
			try
			{
				SaveFileDialog sfd = new SaveFileDialog()
				{
					InitialDirectory = @"C:\",
					Filter = "Texte (*.txt)|*.txt|" + 
					"Alle Dateien (*.*)|*.*",
					Title = "Datei zum Speichern auswählen"
				};

				// Funktion verlassen, wenn nicht der Button "Speichern" gedrückt wurde
				if (sfd.ShowDialog() != DialogResult.OK) return ;

				// Filestream-Objekt erstellen
				// Pfadangaben mit @ am Anfang
				FileStream fs = new FileStream(sfd.FileName, FileMode.Create);

				// StreamWriter-Objekt erstellen
				StreamWriter sw = new StreamWriter(fs);

				// Jedes Element der Liste einzeln in die Datei schreiben
				foreach (var item in lstListe.Items)
				{
					sw.WriteLine(item);
				}

				sw.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnLaden_Click(object sender, EventArgs e)
		{
			// Dateizugriff immer innerhalb eines try-catch-Blocks verwenden!
			try
			{
				var ofd = new OpenFileDialog()
				{
					InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
					Filter = "Texte (*.txt)|*.txt|" +
					"Alle Dateien (*.*)|*.*",
					Title = "Datei zum Öffnen auswählen"
				};

				// Prüfen, ob der Button "Öffnen" gedrückt wurde
				if (ofd.ShowDialog() != DialogResult.OK) return;

				// FileStream-Objekt erstellen
				FileStream fs = new FileStream(ofd.FileName, FileMode.Open);

				// StreamReader-Objekt erstellen
				StreamReader sr = new StreamReader(fs);

				string zeile;
				lstListe.Items.Clear();

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
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
