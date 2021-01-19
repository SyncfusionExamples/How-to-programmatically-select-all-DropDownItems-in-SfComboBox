//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Diagnostics;
using System.Xml.Linq;
using System.Data;
using System.Drawing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfComboBoxAdvCheckBox
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
