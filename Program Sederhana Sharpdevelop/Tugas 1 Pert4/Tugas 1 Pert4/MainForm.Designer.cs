﻿/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 02/03/2022
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas_1_Pert4
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
			this.label1 = new System.Windows.Forms.Label();
			this.tBNama = new System.Windows.Forms.TextBox();
			this.btnKirim = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(49, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masukkan Nama";
			// 
			// tBNama
			// 
			this.tBNama.Location = new System.Drawing.Point(190, 93);
			this.tBNama.Name = "tBNama";
			this.tBNama.Size = new System.Drawing.Size(253, 22);
			this.tBNama.TabIndex = 1;
			// 
			// btnKirim
			// 
			this.btnKirim.Location = new System.Drawing.Point(180, 169);
			this.btnKirim.Name = "btnKirim";
			this.btnKirim.Size = new System.Drawing.Size(75, 23);
			this.btnKirim.TabIndex = 2;
			this.btnKirim.Text = "Kirim";
			this.btnKirim.UseVisualStyleBackColor = true;
			this.btnKirim.Click += new System.EventHandler(this.BtnKirimClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(507, 376);
			this.Controls.Add(this.btnKirim);
			this.Controls.Add(this.tBNama);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas 1 Pert4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnKirim;
		private System.Windows.Forms.TextBox tBNama;
		private System.Windows.Forms.Label label1;
	}
}
