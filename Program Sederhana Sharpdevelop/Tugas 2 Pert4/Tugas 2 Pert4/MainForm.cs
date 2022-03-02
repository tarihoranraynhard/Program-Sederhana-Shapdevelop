/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 02/03/2022
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_2_Pert4
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnKirimClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Nama : " + this.tBNama.Text + "     ||     " + " NIM : " + this.tBNIM.Text + "     ||     "  + " Kelas : " + this.tBKelas.Text + "     ||     "  + " Mata Kuliah : " + this.tBMatkul.Text);			
		
			tBNama.Clear();
			tBNIM.Clear();
			tBKelas.Clear();
			tBMatkul.Clear();
		}
	}
}
