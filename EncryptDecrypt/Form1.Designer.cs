//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System;

using System.ComponentModel;
using System.Text;

namespace EncryptDecrypt
{
	public partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabTextEncryption = new System.Windows.Forms.TabPage();
            this.lblSecretKey = new System.Windows.Forms.Label();
            this.lblEncrypted = new System.Windows.Forms.Label();
            this.lblDecrypted = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtPhrase = new System.Windows.Forms.TextBox();
            this.txtDecrypt = new System.Windows.Forms.TextBox();
            this.txtEncrypt = new System.Windows.Forms.TextBox();
            this.tabFileEncryption = new System.Windows.Forms.TabPage();
            this.txtDestinationEncrypt = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnFileEncrypt = new System.Windows.Forms.Button();
            this.txtConPassEncrypt = new System.Windows.Forms.TextBox();
            this.txtPassEncrypt = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnBrowseEncrypt = new System.Windows.Forms.Button();
            this.txtFileToEncrypt = new System.Windows.Forms.TextBox();
            this.tabFileDecryption = new System.Windows.Forms.TabPage();
            this.txtDestinationDecrypt = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnFileDecrypt = new System.Windows.Forms.Button();
            this.txtConPassDecrypt = new System.Windows.Forms.TextBox();
            this.txtPassDecrypt = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnBrowseDecrypt = new System.Windows.Forms.Button();
            this.txtFileToDecrypt = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.process1 = new System.Diagnostics.Process();
            this.tabControl1.SuspendLayout();
            this.tabTextEncryption.SuspendLayout();
            this.tabFileEncryption.SuspendLayout();
            this.tabFileDecryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabTextEncryption);
            this.tabControl1.Controls.Add(this.tabFileEncryption);
            this.tabControl1.Controls.Add(this.tabFileDecryption);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1153, 252);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 8;
            // 
            // tabTextEncryption
            // 
            this.tabTextEncryption.Controls.Add(this.lblSecretKey);
            this.tabTextEncryption.Controls.Add(this.lblEncrypted);
            this.tabTextEncryption.Controls.Add(this.lblDecrypted);
            this.tabTextEncryption.Controls.Add(this.btnDecrypt);
            this.tabTextEncryption.Controls.Add(this.btnEncrypt);
            this.tabTextEncryption.Controls.Add(this.txtPhrase);
            this.tabTextEncryption.Controls.Add(this.txtDecrypt);
            this.tabTextEncryption.Controls.Add(this.txtEncrypt);
            this.tabTextEncryption.Location = new System.Drawing.Point(4, 29);
            this.tabTextEncryption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTextEncryption.Name = "tabTextEncryption";
            this.tabTextEncryption.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabTextEncryption.Size = new System.Drawing.Size(1145, 219);
            this.tabTextEncryption.TabIndex = 0;
            this.tabTextEncryption.Text = "Text Encryption/Decryption";
            this.tabTextEncryption.UseVisualStyleBackColor = true;
            // 
            // lblSecretKey
            // 
            this.lblSecretKey.AutoSize = true;
            this.lblSecretKey.Location = new System.Drawing.Point(525, 14);
            this.lblSecretKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSecretKey.Name = "lblSecretKey";
            this.lblSecretKey.Size = new System.Drawing.Size(107, 20);
            this.lblSecretKey.TabIndex = 15;
            this.lblSecretKey.Text = "Encryption Key";
            // 
            // lblEncrypted
            // 
            this.lblEncrypted.AutoSize = true;
            this.lblEncrypted.Location = new System.Drawing.Point(973, 15);
            this.lblEncrypted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncrypted.Name = "lblEncrypted";
            this.lblEncrypted.Size = new System.Drawing.Size(146, 20);
            this.lblEncrypted.TabIndex = 14;
            this.lblEncrypted.Text = "Encrypted/input Text";
            // 
            // lblDecrypted
            // 
            this.lblDecrypted.AutoSize = true;
            this.lblDecrypted.Location = new System.Drawing.Point(31, 14);
            this.lblDecrypted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecrypted.Name = "lblDecrypted";
            this.lblDecrypted.Size = new System.Drawing.Size(149, 20);
            this.lblDecrypted.TabIndex = 13;
            this.lblDecrypted.Text = "Decrypted/Input Text";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(532, 142);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 35);
            this.btnDecrypt.TabIndex = 12;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(532, 80);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 35);
            this.btnEncrypt.TabIndex = 11;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtPhrase
            // 
            this.txtPhrase.Location = new System.Drawing.Point(505, 40);
            this.txtPhrase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhrase.MaxLength = 10;
            this.txtPhrase.Name = "txtPhrase";
            this.txtPhrase.PasswordChar = '*';
            this.txtPhrase.Size = new System.Drawing.Size(143, 27);
            this.txtPhrase.TabIndex = 10;
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(977, 40);
            this.txtDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDecrypt.Multiline = true;
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(156, 136);
            this.txtDecrypt.TabIndex = 9;
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(16, 40);
            this.txtEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEncrypt.Multiline = true;
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(172, 136);
            this.txtEncrypt.TabIndex = 8;
            // 
            // tabFileEncryption
            // 
            this.tabFileEncryption.Controls.Add(this.txtDestinationEncrypt);
            this.tabFileEncryption.Controls.Add(this.Label4);
            this.tabFileEncryption.Controls.Add(this.btnFileEncrypt);
            this.tabFileEncryption.Controls.Add(this.txtConPassEncrypt);
            this.tabFileEncryption.Controls.Add(this.txtPassEncrypt);
            this.tabFileEncryption.Controls.Add(this.Label1);
            this.tabFileEncryption.Controls.Add(this.Label3);
            this.tabFileEncryption.Controls.Add(this.Label2);
            this.tabFileEncryption.Controls.Add(this.btnBrowseEncrypt);
            this.tabFileEncryption.Controls.Add(this.txtFileToEncrypt);
            this.tabFileEncryption.Location = new System.Drawing.Point(4, 29);
            this.tabFileEncryption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFileEncryption.Name = "tabFileEncryption";
            this.tabFileEncryption.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFileEncryption.Size = new System.Drawing.Size(1145, 219);
            this.tabFileEncryption.TabIndex = 1;
            this.tabFileEncryption.Text = "File Encryption";
            this.tabFileEncryption.UseVisualStyleBackColor = true;
            // 
            // txtDestinationEncrypt
            // 
            this.txtDestinationEncrypt.Location = new System.Drawing.Point(174, 58);
            this.txtDestinationEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationEncrypt.Name = "txtDestinationEncrypt";
            this.txtDestinationEncrypt.ReadOnly = true;
            this.txtDestinationEncrypt.Size = new System.Drawing.Size(863, 27);
            this.txtDestinationEncrypt.TabIndex = 21;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(49, 60);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(117, 25);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "File Info";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFileEncrypt
            // 
            this.btnFileEncrypt.Enabled = false;
            this.btnFileEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileEncrypt.Location = new System.Drawing.Point(1049, 108);
            this.btnFileEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFileEncrypt.Name = "btnFileEncrypt";
            this.btnFileEncrypt.Size = new System.Drawing.Size(96, 49);
            this.btnFileEncrypt.TabIndex = 19;
            this.btnFileEncrypt.Text = "Encrypt";
            this.btnFileEncrypt.Click += new System.EventHandler(this.btnFileEncrypt_Click);
            // 
            // txtConPassEncrypt
            // 
            this.txtConPassEncrypt.Location = new System.Drawing.Point(177, 146);
            this.txtConPassEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConPassEncrypt.Name = "txtConPassEncrypt";
            this.txtConPassEncrypt.PasswordChar = '*';
            this.txtConPassEncrypt.Size = new System.Drawing.Size(860, 27);
            this.txtConPassEncrypt.TabIndex = 18;
            // 
            // txtPassEncrypt
            // 
            this.txtPassEncrypt.Location = new System.Drawing.Point(177, 109);
            this.txtPassEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassEncrypt.Name = "txtPassEncrypt";
            this.txtPassEncrypt.PasswordChar = '*';
            this.txtPassEncrypt.Size = new System.Drawing.Size(860, 27);
            this.txtPassEncrypt.TabIndex = 17;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(92, 19);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 31);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "File Path";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(11, 146);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(158, 31);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Confirm Password";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(24, 109);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(145, 31);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Password";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowseEncrypt
            // 
            this.btnBrowseEncrypt.Location = new System.Drawing.Point(1045, 16);
            this.btnBrowseEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseEncrypt.Name = "btnBrowseEncrypt";
            this.btnBrowseEncrypt.Size = new System.Drawing.Size(96, 32);
            this.btnBrowseEncrypt.TabIndex = 13;
            this.btnBrowseEncrypt.Text = "Open File";
            this.btnBrowseEncrypt.Click += new System.EventHandler(this.btnBrowseEncrypt_Click);
            // 
            // txtFileToEncrypt
            // 
            this.txtFileToEncrypt.Location = new System.Drawing.Point(174, 19);
            this.txtFileToEncrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileToEncrypt.Name = "txtFileToEncrypt";
            this.txtFileToEncrypt.ReadOnly = true;
            this.txtFileToEncrypt.Size = new System.Drawing.Size(863, 27);
            this.txtFileToEncrypt.TabIndex = 12;
            // 
            // tabFileDecryption
            // 
            this.tabFileDecryption.Controls.Add(this.txtDestinationDecrypt);
            this.tabFileDecryption.Controls.Add(this.Label5);
            this.tabFileDecryption.Controls.Add(this.btnFileDecrypt);
            this.tabFileDecryption.Controls.Add(this.txtConPassDecrypt);
            this.tabFileDecryption.Controls.Add(this.txtPassDecrypt);
            this.tabFileDecryption.Controls.Add(this.Label6);
            this.tabFileDecryption.Controls.Add(this.Label7);
            this.tabFileDecryption.Controls.Add(this.Label8);
            this.tabFileDecryption.Controls.Add(this.btnBrowseDecrypt);
            this.tabFileDecryption.Controls.Add(this.txtFileToDecrypt);
            this.tabFileDecryption.Location = new System.Drawing.Point(4, 29);
            this.tabFileDecryption.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabFileDecryption.Name = "tabFileDecryption";
            this.tabFileDecryption.Size = new System.Drawing.Size(1145, 219);
            this.tabFileDecryption.TabIndex = 2;
            this.tabFileDecryption.Text = "File Decryption";
            this.tabFileDecryption.UseVisualStyleBackColor = true;
            // 
            // txtDestinationDecrypt
            // 
            this.txtDestinationDecrypt.Location = new System.Drawing.Point(125, 66);
            this.txtDestinationDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDestinationDecrypt.Name = "txtDestinationDecrypt";
            this.txtDestinationDecrypt.ReadOnly = true;
            this.txtDestinationDecrypt.Size = new System.Drawing.Size(899, 27);
            this.txtDestinationDecrypt.TabIndex = 32;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(4, 68);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(117, 25);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "File Info";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnFileDecrypt
            // 
            this.btnFileDecrypt.Enabled = false;
            this.btnFileDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFileDecrypt.Location = new System.Drawing.Point(1032, 115);
            this.btnFileDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFileDecrypt.Name = "btnFileDecrypt";
            this.btnFileDecrypt.Size = new System.Drawing.Size(96, 49);
            this.btnFileDecrypt.TabIndex = 30;
            this.btnFileDecrypt.Text = "Decrypt";
            this.btnFileDecrypt.Click += new System.EventHandler(this.btnFileDecrypt_Click);
            // 
            // txtConPassDecrypt
            // 
            this.txtConPassDecrypt.Location = new System.Drawing.Point(125, 152);
            this.txtConPassDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConPassDecrypt.Name = "txtConPassDecrypt";
            this.txtConPassDecrypt.PasswordChar = '*';
            this.txtConPassDecrypt.Size = new System.Drawing.Size(899, 27);
            this.txtConPassDecrypt.TabIndex = 29;
            // 
            // txtPassDecrypt
            // 
            this.txtPassDecrypt.Location = new System.Drawing.Point(125, 115);
            this.txtPassDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassDecrypt.Name = "txtPassDecrypt";
            this.txtPassDecrypt.PasswordChar = '*';
            this.txtPassDecrypt.Size = new System.Drawing.Size(899, 27);
            this.txtPassDecrypt.TabIndex = 28;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(11, 29);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(107, 25);
            this.Label6.TabIndex = 27;
            this.Label6.Text = "File Path";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(-17, 152);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(139, 25);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Confirm Password";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(4, 118);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(117, 25);
            this.Label8.TabIndex = 25;
            this.Label8.Text = "Password";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBrowseDecrypt
            // 
            this.btnBrowseDecrypt.Location = new System.Drawing.Point(1033, 29);
            this.btnBrowseDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseDecrypt.Name = "btnBrowseDecrypt";
            this.btnBrowseDecrypt.Size = new System.Drawing.Size(96, 32);
            this.btnBrowseDecrypt.TabIndex = 24;
            this.btnBrowseDecrypt.Text = "Open File";
            this.btnBrowseDecrypt.Click += new System.EventHandler(this.btnBrowseDecrypt_Click);
            // 
            // txtFileToDecrypt
            // 
            this.txtFileToDecrypt.Location = new System.Drawing.Point(125, 29);
            this.txtFileToDecrypt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFileToDecrypt.Name = "txtFileToDecrypt";
            this.txtFileToDecrypt.ReadOnly = true;
            this.txtFileToDecrypt.Size = new System.Drawing.Size(899, 27);
            this.txtFileToDecrypt.TabIndex = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1156, 258);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Encrypt/Decrypt";
            this.tabControl1.ResumeLayout(false);
            this.tabTextEncryption.ResumeLayout(false);
            this.tabTextEncryption.PerformLayout();
            this.tabFileEncryption.ResumeLayout(false);
            this.tabFileEncryption.PerformLayout();
            this.tabFileDecryption.ResumeLayout(false);
            this.tabFileDecryption.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabFileEncryption;
		private System.Windows.Forms.TabPage tabFileDecryption;
		private System.Windows.Forms.TabPage tabTextEncryption;
		private System.Windows.Forms.Label lblSecretKey;
		private System.Windows.Forms.Label lblEncrypted;
		private System.Windows.Forms.Label lblDecrypted;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.TextBox txtPhrase;
		private System.Windows.Forms.TextBox txtDecrypt;
		private System.Windows.Forms.TextBox txtEncrypt;
		internal System.Windows.Forms.TextBox txtDestinationEncrypt;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Button btnFileEncrypt;
		internal System.Windows.Forms.TextBox txtConPassEncrypt;
		internal System.Windows.Forms.TextBox txtPassEncrypt;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Button btnBrowseEncrypt;
		internal System.Windows.Forms.TextBox txtFileToEncrypt;
		internal System.Windows.Forms.TextBox txtDestinationDecrypt;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button btnFileDecrypt;
		internal System.Windows.Forms.TextBox txtConPassDecrypt;
		internal System.Windows.Forms.TextBox txtPassDecrypt;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Button btnBrowseDecrypt;
		internal System.Windows.Forms.TextBox txtFileToDecrypt;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Process process1;
    }
}

