/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 02/03/2022
 * Time: 14:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace Tugas_2_Pert4
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
