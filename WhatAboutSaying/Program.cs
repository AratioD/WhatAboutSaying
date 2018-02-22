
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
			
			Sayings says = new Sayings("ketun häntä kainalossa", "foxtail in the armpit");
			Debug.WriteLine(says.getFinSay());
			Debug.WriteLine(says.getEngSay());
			
			Sayings says2 = new Sayings("oma lehmä ojassa", "own cow in the ditch");
			Debug.WriteLine(says2.getFinSay());
			Debug.WriteLine(says2.getEngSay());
			
			int n = 1;
			while (n < 6)
			{
				Debug.WriteLine("Current value of n is {0}", n);
				n++;
			}
			
			
		}
	}
}
