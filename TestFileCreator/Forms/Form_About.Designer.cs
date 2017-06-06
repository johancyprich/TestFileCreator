namespace TestFileCreator
{
	partial class Form_About
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_About));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label_AppName = new System.Windows.Forms.Label();
			this.label_AppVersion = new System.Windows.Forms.Label();
			this.label_Copyright = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.linkLabel_WebSite = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(360, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label_AppName
			// 
			this.label_AppName.AutoSize = true;
			this.label_AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_AppName.Location = new System.Drawing.Point(12, 179);
			this.label_AppName.Name = "label_AppName";
			this.label_AppName.Size = new System.Drawing.Size(143, 20);
			this.label_AppName.TabIndex = 1;
			this.label_AppName.Text = "Test File Creator";
			// 
			// label_AppVersion
			// 
			this.label_AppVersion.AutoSize = true;
			this.label_AppVersion.Location = new System.Drawing.Point(13, 204);
			this.label_AppVersion.Name = "label_AppVersion";
			this.label_AppVersion.Size = new System.Drawing.Size(69, 13);
			this.label_AppVersion.TabIndex = 2;
			this.label_AppVersion.Text = "Version 1.0.0";
			// 
			// label_Copyright
			// 
			this.label_Copyright.AutoSize = true;
			this.label_Copyright.Location = new System.Drawing.Point(13, 221);
			this.label_Copyright.Name = "label_Copyright";
			this.label_Copyright.Size = new System.Drawing.Size(256, 13);
			this.label_Copyright.TabIndex = 3;
			this.label_Copyright.Text = "Copyright (C) 2017 Johan Cyprich. All rights reserved.";
			// 
			// button_OK
			// 
			this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button_OK.Location = new System.Drawing.Point(142, 244);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(75, 23);
			this.button_OK.TabIndex = 4;
			this.button_OK.Text = "&OK";
			this.button_OK.UseVisualStyleBackColor = true;
			// 
			// linkLabel_WebSite
			// 
			this.linkLabel_WebSite.AutoSize = true;
			this.linkLabel_WebSite.Location = new System.Drawing.Point(281, 179);
			this.linkLabel_WebSite.Name = "linkLabel_WebSite";
			this.linkLabel_WebSite.Size = new System.Drawing.Size(65, 13);
			this.linkLabel_WebSite.TabIndex = 5;
			this.linkLabel_WebSite.TabStop = true;
			this.linkLabel_WebSite.Text = "Cyprich.com";
			this.linkLabel_WebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_WebSite_LinkClicked);
			// 
			// Form_About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 278);
			this.Controls.Add(this.linkLabel_WebSite);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.label_Copyright);
			this.Controls.Add(this.label_AppVersion);
			this.Controls.Add(this.label_AppName);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_About";
			this.ShowInTaskbar = false;
			this.Text = "About";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label_AppName;
		private System.Windows.Forms.Label label_AppVersion;
		private System.Windows.Forms.Label label_Copyright;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.LinkLabel linkLabel_WebSite;
	}
}