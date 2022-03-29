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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                MyEncryptor enc = new MyEncryptor(txtPhrase.Text.Trim());
                txtDecrypt.Text = enc.Encrypt(txtEncrypt.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                MyEncryptor enc = new MyEncryptor(txtPhrase.Text.Trim());
                txtEncrypt.Text = enc.Decrypt(txtDecrypt.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBrowseDecrypt_Click(object sender, EventArgs e)
        {
            //Setup the open dialog.
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Choose a file to decrypt";
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "Encrypted Files (*.encrypt) | *.encrypt";

            string strFileToDecrypt = "";
            string strOutputDecrypt = "";

            //Find out if the user chose a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileToDecrypt = openFileDialog1.FileName;
                txtFileToDecrypt.Text = strFileToDecrypt;
                int iPosition = 0;
                //                 Get the position of the last "\" in the OpenFileDialog.FileName path.
                //                * -1 is when the character your searching for is not there.
                //                * IndexOf searches from left to right.
                iPosition = strFileToDecrypt.LastIndexOf(".encrypt");
                if ((iPosition == -1) || (iPosition != (strFileToDecrypt.Length - 8)))
                {
                    MessageBox.Show("Invalid file. Please select proper encrypted file.");
                }

                //strOutputFile = the file path minus the last 8 characters (.encrypt)
                strOutputDecrypt = strFileToDecrypt.Substring(0, strFileToDecrypt.Length - 8);
                //Assign strOutputFile to the position after the last "\" in the path.
                iPosition = strOutputDecrypt.IndexOf("z_z");
                if (iPosition == -1)
                {
                    strOutputDecrypt = strOutputDecrypt + ".dat";
                }
                else
                {
                    strOutputDecrypt = strOutputDecrypt.Replace("z_z", ".");
                }
                txtDestinationDecrypt.Text = strOutputDecrypt;
                //Update buttons
                btnFileDecrypt.Enabled = true;

            }
        }

        private void btnBrowseEncrypt_Click(object sender, EventArgs e)
        {
            //Setup the open dialog.
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Choose a file to decrypt";
            openFileDialog1.InitialDirectory = "C:\\";
            // openFileDialog1.Filter = "Encrypted Files (*.encrypt) | *.encrypt";

            string strFileToEncrypt = "";
            string strOutputEncrypt = "";
            string strExtension = "";

            //Find out if the user chose a file.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                strFileToEncrypt = openFileDialog1.FileName;
                txtFileToEncrypt.Text = strFileToEncrypt;
                int iPosition = 0;
                //                 Get the position of the last "\" in the OpenFileDialog.FileName path.
                //                * -1 is when the character your searching for is not there.
                //                * IndexOf searches from left to right.
                iPosition = strFileToEncrypt.LastIndexOf(".");
                if (iPosition == -1)
                {
                    MessageBox.Show("Invalid file. Please select proper file.");
                }

                //strOutputFile = the file path minus the last 8 characters (.encrypt)
                strExtension = strFileToEncrypt.Substring(iPosition, (strFileToEncrypt.Length - iPosition));
                //Assign strOutputFile to the position after the last "\" in the path.  
                string strEncryptedExt = "z_z" + strExtension.Substring(1) + ".encrypt";
                strOutputEncrypt = strFileToEncrypt.Replace(strExtension, strEncryptedExt);

                txtDestinationEncrypt.Text = strOutputEncrypt;
                //Update buttons
                btnFileEncrypt.Enabled = true;
            }
        }

        private void btnFileDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConPassDecrypt.Text != txtPassDecrypt.Text)
                {
                    txtConPassDecrypt.Text = "";
                    MessageBox.Show("Password are not same. Please verify once again.");
                    return;
                }
                string strSecretKey = txtPassDecrypt.Text.Trim();
                MyEncryptor enc = new MyEncryptor(strSecretKey);
                enc.Decrypt(txtFileToDecrypt.Text, txtDestinationDecrypt.Text);
                MessageBox.Show(@"The operation has been finished successfully.
Please check the input file Directory");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFileEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConPassEncrypt.Text != txtPassEncrypt.Text)
                {
                    txtConPassEncrypt.Text = "";
                    MessageBox.Show("Password are not same. Please verify once again.");
                    return;
                }
                string strSecretKey = txtPassEncrypt.Text.Trim();
                MyEncryptor enc = new MyEncryptor(strSecretKey);
                enc.Encrypt(txtFileToEncrypt.Text, txtDestinationEncrypt.Text);
                MessageBox.Show(@"The operation has been finished successfully.
Please check the input file Directory");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}