using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileCreator
{
	public partial class Form_About : Form
	{
		public Form_About ()
		{
			InitializeComponent ();
		}

		private void linkLabel_WebSite_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start ("http://www.cyprich.com");
		}
	}
}
