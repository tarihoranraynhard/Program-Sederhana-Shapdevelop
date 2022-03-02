/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 02/03/2022
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas_2_Pert4
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tBNama = new System.Windows.Forms.TextBox();
			this.tBNIM = new System.Windows.Forms.TextBox();
			this.tBKelas = new System.Windows.Forms.TextBox();
			this.tBMatkul = new System.Windows.Forms.TextBox();
			this.btnKirim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(195, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "BIODATA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(30, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "NIM";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(30, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kelas";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(30, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Mata Kuliah";
			// 
			// tBNama
			// 
			this.tBNama.Location = new System.Drawing.Point(172, 97);
			this.tBNama.Name = "tBNama";
			this.tBNama.Size = new System.Drawing.Size(276, 22);
			this.tBNama.TabIndex = 5;
			// 
			// tBNIM
			// 
			this.tBNIM.Location = new System.Drawing.Point(172, 131);
			this.tBNIM.Name = "tBNIM";
			this.tBNIM.Size = new System.Drawing.Size(276, 22);
			this.tBNIM.TabIndex = 6;
			// 
			// tBKelas
			// 
			this.tBKelas.Location = new System.Drawing.Point(172, 168);
			this.tBKelas.Name = "tBKelas";
			this.tBKelas.Size = new System.Drawing.Size(276, 22);
			this.tBKelas.TabIndex = 7;
			// 
			// tBMatkul
			// 
			this.tBMatkul.Location = new System.Drawing.Point(172, 206);
			this.tBMatkul.Name = "tBMatkul";
			this.tBMatkul.Size = new System.Drawing.Size(276, 22);
			this.tBMatkul.TabIndex = 8;
			// 
			// btnKirim
			// 
			this.btnKirim.Location = new System.Drawing.Point(195, 260);
			this.btnKirim.Name = "btnKirim";
			this.btnKirim.Size = new System.Drawing.Size(75, 27);
			this.btnKirim.TabIndex = 9;
			this.btnKirim.Text = "Kirim";
			this.btnKirim.UseVisualStyleBackColor = true;
			this.btnKirim.Click += new System.EventHandler(this.BtnKirimClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(504, 378);
			this.Controls.Add(this.btnKirim);
			this.Controls.Add(this.tBMatkul);
			this.Controls.Add(this.tBKelas);
			this.Controls.Add(this.tBNIM);
			this.Controls.Add(this.tBNama);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas 2 Pert4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnKirim;
		private System.Windows.Forms.TextBox tBMatkul;
		private System.Windows.Forms.TextBox tBKelas;
		private System.Windows.Forms.TextBox tBNIM;
		private System.Windows.Forms.TextBox tBNama;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
