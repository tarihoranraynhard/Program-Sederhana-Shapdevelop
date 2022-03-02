/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 02/03/2022
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tugas_1_Pert4
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
			MessageBox.Show ("Hello World " + this.tBNama.Text);
		}
	}
}
