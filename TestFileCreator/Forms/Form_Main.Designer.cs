namespace TestFileCreator
{
	partial class Form_Main
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuStrip_File = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_File_Create = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_File_Separator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Help_License = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip_Help_About = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel_WriteStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.label_FileName = new System.Windows.Forms.Label();
			this.label_FileSize = new System.Windows.Forms.Label();
			this.textBox_FileName = new System.Windows.Forms.TextBox();
			this.textBox_FileSize = new System.Windows.Forms.TextBox();
			this.comboBox_ByteType = new System.Windows.Forms.ComboBox();
			this.button_Create = new System.Windows.Forms.Button();
			this.button_FilePath = new System.Windows.Forms.Button();
			this.label_ActualFileSize = new System.Windows.Forms.Label();
			this.label_ActualFileSizeValue = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.menuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_File,
            this.menuStrip_Help});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(378, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// menuStrip_File
			// 
			this.menuStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_File_Create,
            this.menuStrip_File_Separator1,
            this.menuStrip_File_Exit});
			this.menuStrip_File.Name = "menuStrip_File";
			this.menuStrip_File.Size = new System.Drawing.Size(37, 20);
			this.menuStrip_File.Text = "&File";
			// 
			// menuStrip_File_Create
			// 
			this.menuStrip_File_Create.Name = "menuStrip_File_Create";
			this.menuStrip_File_Create.Size = new System.Drawing.Size(129, 22);
			this.menuStrip_File_Create.Text = "Create";
			this.menuStrip_File_Create.Click += new System.EventHandler(this.menuStrip_File_Create_Click);
			// 
			// menuStrip_File_Separator1
			// 
			this.menuStrip_File_Separator1.Name = "menuStrip_File_Separator1";
			this.menuStrip_File_Separator1.Size = new System.Drawing.Size(126, 6);
			// 
			// menuStrip_File_Exit
			// 
			this.menuStrip_File_Exit.Name = "menuStrip_File_Exit";
			this.menuStrip_File_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
			this.menuStrip_File_Exit.Size = new System.Drawing.Size(129, 22);
			this.menuStrip_File_Exit.Text = "E&xit";
			this.menuStrip_File_Exit.Click += new System.EventHandler(this.menuStrip_File_Exit_Click);
			// 
			// menuStrip_Help
			// 
			this.menuStrip_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_Help_License,
            this.menuStrip_Help_About});
			this.menuStrip_Help.Name = "menuStrip_Help";
			this.menuStrip_Help.Size = new System.Drawing.Size(44, 20);
			this.menuStrip_Help.Text = "&Help";
			// 
			// menuStrip_Help_License
			// 
			this.menuStrip_Help_License.Name = "menuStrip_Help_License";
			this.menuStrip_Help_License.Size = new System.Drawing.Size(152, 22);
			this.menuStrip_Help_License.Text = "License";
			this.menuStrip_Help_License.Click += new System.EventHandler(this.menuStrip_Help_License_Click);
			// 
			// menuStrip_Help_About
			// 
			this.menuStrip_Help_About.Name = "menuStrip_Help_About";
			this.menuStrip_Help_About.Size = new System.Drawing.Size(152, 22);
			this.menuStrip_Help_About.Text = "&About";
			this.menuStrip_Help_About.Click += new System.EventHandler(this.menuStrip_Help_About_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_WriteStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 182);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(378, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel_WriteStatus
			// 
			this.toolStripStatusLabel_WriteStatus.Name = "toolStripStatusLabel_WriteStatus";
			this.toolStripStatusLabel_WriteStatus.Size = new System.Drawing.Size(72, 17);
			this.toolStripStatusLabel_WriteStatus.Text = "Version 1.0.0";
			// 
			// label_FileName
			// 
			this.label_FileName.AutoSize = true;
			this.label_FileName.Location = new System.Drawing.Point(18, 46);
			this.label_FileName.Name = "label_FileName";
			this.label_FileName.Size = new System.Drawing.Size(57, 13);
			this.label_FileName.TabIndex = 2;
			this.label_FileName.Text = "File Name:";
			// 
			// label_FileSize
			// 
			this.label_FileSize.AutoSize = true;
			this.label_FileSize.Location = new System.Drawing.Point(26, 72);
			this.label_FileSize.Name = "label_FileSize";
			this.label_FileSize.Size = new System.Drawing.Size(49, 13);
			this.label_FileSize.TabIndex = 3;
			this.label_FileSize.Text = "File Size:";
			// 
			// textBox_FileName
			// 
			this.textBox_FileName.Location = new System.Drawing.Point(81, 43);
			this.textBox_FileName.Name = "textBox_FileName";
			this.textBox_FileName.Size = new System.Drawing.Size(249, 20);
			this.textBox_FileName.TabIndex = 4;
			// 
			// textBox_FileSize
			// 
			this.textBox_FileSize.Location = new System.Drawing.Point(81, 69);
			this.textBox_FileSize.Name = "textBox_FileSize";
			this.textBox_FileSize.Size = new System.Drawing.Size(128, 20);
			this.textBox_FileSize.TabIndex = 5;
			this.textBox_FileSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FileSize_KeyPress);
			this.textBox_FileSize.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FileSize_KeyUp);
			// 
			// comboBox_ByteType
			// 
			this.comboBox_ByteType.FormattingEnabled = true;
			this.comboBox_ByteType.Location = new System.Drawing.Point(215, 69);
			this.comboBox_ByteType.Name = "comboBox_ByteType";
			this.comboBox_ByteType.Size = new System.Drawing.Size(56, 21);
			this.comboBox_ByteType.TabIndex = 6;
			this.comboBox_ByteType.SelectedIndexChanged += new System.EventHandler(this.comboBox_ByteType_SelectedIndexChanged);
			// 
			// button_Create
			// 
			this.button_Create.Location = new System.Drawing.Point(152, 144);
			this.button_Create.Name = "button_Create";
			this.button_Create.Size = new System.Drawing.Size(75, 23);
			this.button_Create.TabIndex = 7;
			this.button_Create.Text = "&Create";
			this.button_Create.UseVisualStyleBackColor = true;
			this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
			// 
			// button_FilePath
			// 
			this.button_FilePath.Location = new System.Drawing.Point(336, 41);
			this.button_FilePath.Name = "button_FilePath";
			this.button_FilePath.Size = new System.Drawing.Size(25, 23);
			this.button_FilePath.TabIndex = 8;
			this.button_FilePath.Text = "...";
			this.button_FilePath.UseVisualStyleBackColor = true;
			this.button_FilePath.Click += new System.EventHandler(this.button_FilePath_Click);
			// 
			// label_ActualFileSize
			// 
			this.label_ActualFileSize.AutoSize = true;
			this.label_ActualFileSize.Location = new System.Drawing.Point(18, 115);
			this.label_ActualFileSize.Name = "label_ActualFileSize";
			this.label_ActualFileSize.Size = new System.Drawing.Size(82, 13);
			this.label_ActualFileSize.TabIndex = 9;
			this.label_ActualFileSize.Text = "Actual File Size:";
			// 
			// label_ActualFileSizeValue
			// 
			this.label_ActualFileSizeValue.AutoSize = true;
			this.label_ActualFileSizeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_ActualFileSizeValue.Location = new System.Drawing.Point(106, 115);
			this.label_ActualFileSizeValue.Name = "label_ActualFileSizeValue";
			this.label_ActualFileSizeValue.Size = new System.Drawing.Size(36, 13);
			this.label_ActualFileSizeValue.TabIndex = 10;
			this.label_ActualFileSizeValue.Text = "0 MB";
			// 
			// Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 204);
			this.Controls.Add(this.label_ActualFileSizeValue);
			this.Controls.Add(this.label_ActualFileSize);
			this.Controls.Add(this.button_FilePath);
			this.Controls.Add(this.button_Create);
			this.Controls.Add(this.comboBox_ByteType);
			this.Controls.Add(this.textBox_FileSize);
			this.Controls.Add(this.textBox_FileName);
			this.Controls.Add(this.label_FileSize);
			this.Controls.Add(this.label_FileName);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "Form_Main";
			this.Text = "Test File Creator";
			this.Load += new System.EventHandler(this.Form_Main_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_File;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_File_Create;
		private System.Windows.Forms.ToolStripSeparator menuStrip_File_Separator1;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_File_Exit;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Help;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Help_About;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label_FileName;
		private System.Windows.Forms.Label label_FileSize;
		private System.Windows.Forms.TextBox textBox_FileName;
		private System.Windows.Forms.TextBox textBox_FileSize;
		private System.Windows.Forms.ComboBox comboBox_ByteType;
		private System.Windows.Forms.Button button_Create;
		private System.Windows.Forms.Button button_FilePath;
		private System.Windows.Forms.Label label_ActualFileSize;
		private System.Windows.Forms.Label label_ActualFileSizeValue;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_WriteStatus;
		private System.Windows.Forms.ToolStripMenuItem menuStrip_Help_License;
	}
}

