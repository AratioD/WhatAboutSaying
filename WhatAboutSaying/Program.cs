/*
 * Created by SharpDevelop.
 * User: CONAHE3
 * Date: 14.2.2018
 * Time: 22.57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using System.Diagnostics;



namespace WhatAboutSaying
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
			//Application.Run(new MainForm());
			
			//Console.WriteLine("heelo jee");
			Console.Beep();
			Console.Beep();
			Debug.WriteLine("jee jee");
			Debug.WriteLine("kylla tama tasta onnistuu");
			
			Sayings says = new Sayings();
			
			//Debug.WriteLine(says.jee);
			//Debug.writeline(says.jee());
			MessageBox.Show(says.jee());
			
			MessageBox.Show(says.numero().ToString("0.######"));
			
			Sayings says2 = new Sayings("jsdfs",23);
			MessageBox.Show(says2.haHaa());
			
			
		}
	}
}
