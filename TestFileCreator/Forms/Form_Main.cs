using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileCreator
{
	public partial class Form_Main : Form
	{
		private long _multiplier = 1;
		private long _fileSize = 0;

		// Constructors

		public Form_Main ()
		{
			InitializeComponent ();
		}


		// Methods


		private void button_Create_Click (object sender, EventArgs e)
		{
			CreateTestFile ();
		}


		private void button_FilePath_Click (object sender, EventArgs e)
		{
			DialogResult result = saveFileDialog1.ShowDialog ();

			if (result == DialogResult.OK)
				textBox_FileName.Text = saveFileDialog1.FileName;
		}


		private void CreateTestFile ()
		{
			Random data = new Random ();

			Cursor.Current = Cursors.WaitCursor;

			toolStripStatusLabel_WriteStatus.ForeColor = Color.Red;
			toolStripStatusLabel_WriteStatus.Text = "Creating file...";
			statusStrip1.Refresh ();

			if (textBox_FileName.Text != "")
			{
				using (BinaryWriter b = new BinaryWriter (
				File.Open (textBox_FileName.Text, FileMode.Create)))
				{
					for (int i = 0; i <= _fileSize; i++)
						b.Write ((byte) data.Next (0, 255));
				}

				toolStripStatusLabel_WriteStatus.ForeColor = Color.Green;
				toolStripStatusLabel_WriteStatus.Text = "Last file created: " + textBox_FileName.Text;
			}

			else
				MessageBox.Show ("Please enter a filename.");

			Cursor.Current = Cursors.Default;
		}


		private void ExitProgram ()
		{
			Application.Exit ();
		}


		private void textBox_FileSize_KeyPress (object sender, KeyPressEventArgs e)
		{
			// Code from https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers.

			if (!char.IsControl (e.KeyChar) && !char.IsDigit (e.KeyChar))
				e.Handled = true;
		}


		private void textBox_FileSize_KeyUp (object sender, KeyEventArgs e)
		{
			UpdateActualFileSize ();
		}


		private void Form_Main_Load (object sender, EventArgs e)
		{
			comboBox_ByteType.Items.Add ("bytes");
			comboBox_ByteType.Items.Add ("KB");
			comboBox_ByteType.Items.Add ("MB");
			comboBox_ByteType.Items.Add ("GB");

			comboBox_ByteType.SelectedIndex = 2;
		}


		private void menuStrip_File_Create_Click (object sender, EventArgs e)
		{
			CreateTestFile ();
		}


		private void menuStrip_File_Exit_Click (object sender, EventArgs e)
		{
			ExitProgram ();
		}


		private void menuStrip_Help_About_Click (object sender, EventArgs e)
		{
			Form_About dlg = new Form_About ();
			dlg.ShowDialog ();
		}


		private void menuStrip_Help_License_Click (object sender, EventArgs e)
		{
			Form_License dlg = new Form_License ();

			dlg.ShowDialog ();
		}


		private void comboBox_ByteType_SelectedIndexChanged (object sender, EventArgs e)
		{
			switch (comboBox_ByteType.SelectedItem.ToString ())
			{
				case "bytes":
					_multiplier = 1;
					break;

				case "KB":
					_multiplier = 1024;
					break;

				case "MB":
					_multiplier = 1024 * 1024;
					break;

				case "GB":
					_multiplier = 1024 * 1024 * 1024;
					break;

				default:
					_multiplier = 1;
					break;
			}

			UpdateActualFileSize ();
		}


		private void UpdateActualFileSize ()
		{
			if (textBox_FileSize.Text == "")
			{
				label_ActualFileSizeValue.Text = "0 bytes";
				_fileSize = 0;
			}

			else
			{
				try
				{
					_fileSize = _multiplier * Convert.ToInt64 (textBox_FileSize.Text);

					var nfi = (NumberFormatInfo) CultureInfo.InvariantCulture.NumberFormat.Clone ();
					nfi.NumberGroupSeparator = " ";

					label_ActualFileSizeValue.Text = _fileSize.ToString ("#,0", nfi) + " bytes";
				}

				catch (Exception e)
				{
					MessageBox.Show ("Error: number too large.");
				}
			}
		}

	}
}
