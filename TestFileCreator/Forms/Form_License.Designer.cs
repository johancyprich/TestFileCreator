namespace TestFileCreator
{
	partial class Form_License
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.tableLayoutPanel_License = new System.Windows.Forms.TableLayoutPanel();
			this.button_OK = new System.Windows.Forms.Button();
			this.textBox_License = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel_License.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel_License
			// 
			this.tableLayoutPanel_License.ColumnCount = 1;
			this.tableLayoutPanel_License.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel_License.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel_License.Controls.Add(this.button_OK, 0, 1);
			this.tableLayoutPanel_License.Controls.Add(this.textBox_License, 0, 0);
			this.tableLayoutPanel_License.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_License.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_License.Name = "tableLayoutPanel_License";
			this.tableLayoutPanel_License.RowCount = 2;
			this.tableLayoutPanel_License.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.83168F));
			this.tableLayoutPanel_License.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.168317F));
			this.tableLayoutPanel_License.Size = new System.Drawing.Size(504, 404);
			this.tableLayoutPanel_License.TabIndex = 0;
			// 
			// button_OK
			// 
			this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Location = new System.Drawing.Point(214, 375);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(75, 23);
			this.button_OK.TabIndex = 0;
			this.button_OK.Text = "&OK";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// textBox_License
			// 
			this.textBox_License.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox_License.Location = new System.Drawing.Point(3, 3);
			this.textBox_License.Multiline = true;
			this.textBox_License.Name = "textBox_License";
			this.textBox_License.Size = new System.Drawing.Size(498, 364);
			this.textBox_License.TabIndex = 1;
			// 
			// Form_License
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 404);
			this.Controls.Add(this.tableLayoutPanel_License);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_License";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "License";
			this.Load += new System.EventHandler(this.Form_License_Load);
			this.tableLayoutPanel_License.ResumeLayout(false);
			this.tableLayoutPanel_License.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_License;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.TextBox textBox_License;
	}
}