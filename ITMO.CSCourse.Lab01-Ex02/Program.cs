/*
В проекте Lab01-Ex02 содержится код упражнений 02 и 03.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CSCourse.Lab01_Ex02
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// Application.Run(new Form1()); - старая форма
			Application.Run(new nForm()); // новая форма
		}
	}
}
