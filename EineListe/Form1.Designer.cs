
namespace EineListe
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lstListe = new System.Windows.Forms.ListBox();
			this.txtStadt = new System.Windows.Forms.TextBox();
			this.btnHinzufügen = new System.Windows.Forms.Button();
			this.btnLöschen = new System.Windows.Forms.Button();
			this.btnAlleLöschen = new System.Windows.Forms.Button();
			this.btnBeenden = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstListe
			// 
			this.lstListe.FormattingEnabled = true;
			this.lstListe.Location = new System.Drawing.Point(13, 13);
			this.lstListe.Name = "lstListe";
			this.lstListe.Size = new System.Drawing.Size(402, 303);
			this.lstListe.TabIndex = 0;
			// 
			// txtStadt
			// 
			this.txtStadt.Location = new System.Drawing.Point(13, 323);
			this.txtStadt.Name = "txtStadt";
			this.txtStadt.Size = new System.Drawing.Size(402, 20);
			this.txtStadt.TabIndex = 1;
			// 
			// btnHinzufügen
			// 
			this.btnHinzufügen.Location = new System.Drawing.Point(13, 350);
			this.btnHinzufügen.Name = "btnHinzufügen";
			this.btnHinzufügen.Size = new System.Drawing.Size(75, 23);
			this.btnHinzufügen.TabIndex = 2;
			this.btnHinzufügen.Text = "Hinzufügen";
			this.btnHinzufügen.UseVisualStyleBackColor = true;
			this.btnHinzufügen.Click += new System.EventHandler(this.btnHinzufügen_Click);
			// 
			// btnLöschen
			// 
			this.btnLöschen.Location = new System.Drawing.Point(95, 350);
			this.btnLöschen.Name = "btnLöschen";
			this.btnLöschen.Size = new System.Drawing.Size(75, 23);
			this.btnLöschen.TabIndex = 3;
			this.btnLöschen.Text = "Löschen";
			this.btnLöschen.UseVisualStyleBackColor = true;
			this.btnLöschen.Click += new System.EventHandler(this.btnLöschen_Click);
			// 
			// btnAlleLöschen
			// 
			this.btnAlleLöschen.Location = new System.Drawing.Point(177, 350);
			this.btnAlleLöschen.Name = "btnAlleLöschen";
			this.btnAlleLöschen.Size = new System.Drawing.Size(75, 23);
			this.btnAlleLöschen.TabIndex = 4;
			this.btnAlleLöschen.Text = "Alle löschen";
			this.btnAlleLöschen.UseVisualStyleBackColor = true;
			this.btnAlleLöschen.Click += new System.EventHandler(this.btnAlleLöschen_Click);
			// 
			// btnBeenden
			// 
			this.btnBeenden.Location = new System.Drawing.Point(340, 349);
			this.btnBeenden.Name = "btnBeenden";
			this.btnBeenden.Size = new System.Drawing.Size(75, 23);
			this.btnBeenden.TabIndex = 5;
			this.btnBeenden.Text = "Beenden";
			this.btnBeenden.UseVisualStyleBackColor = true;
			this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 384);
			this.Controls.Add(this.btnBeenden);
			this.Controls.Add(this.btnAlleLöschen);
			this.Controls.Add(this.btnLöschen);
			this.Controls.Add(this.btnHinzufügen);
			this.Controls.Add(this.txtStadt);
			this.Controls.Add(this.lstListe);
			this.Name = "Form1";
			this.Text = "Auflistung";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstListe;
		private System.Windows.Forms.TextBox txtStadt;
		private System.Windows.Forms.Button btnHinzufügen;
		private System.Windows.Forms.Button btnLöschen;
		private System.Windows.Forms.Button btnAlleLöschen;
		private System.Windows.Forms.Button btnBeenden;
	}
}

