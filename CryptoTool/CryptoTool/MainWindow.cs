using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CryptoTool
{
    public partial class MainWindow : Form
    {
        private bool fileChkSumSelected = false;
        private bool fileEncryptSelected = false;
        private bool hashTypeSelected = false;
        private bool encryptTypeSelected = false;

        public MainWindow()
        {
            InitializeComponent();
            LoadEncryptionAlgorithms();
            LoadHashAlgorithms();
            matchLabel.ForeColor = Color.Red;
            outputFileTextBox.Text = 
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + 
                '\\' + "outfile.enc";
        }

        private void LoadEncryptionAlgorithms()
        {
            string[] algs = Properties.Settings.Default.EncryptionAlgorithms.Split('\n');

            foreach (string alg in algs)
                encryptComboBox.Items.Add(alg.Trim('\r'));
        }

        private void LoadHashAlgorithms()
        {
            string[] algs = Properties.Settings.Default.HashAlgorithms.Split('\n');

            foreach (string alg in algs)
                hashComboBox.Items.Add(alg.Trim('\r'));
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select a file";
            openFileDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (mainWindowTabControl.SelectedTab.Name == "hashCheckerTabPage")
                {
                    fileChkSumPathLabel.Text = openFileDialog.FileName;
                    fileChkSumSelected = true;
                }
                else if (mainWindowTabControl.SelectedTab.Name == "encryptionTabPage")
                {
                    inputFilePathLabel.Text = openFileDialog.FileName;
                    fileEncryptSelected = true;
                }
            }
        }

        private void encryptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            encryptTypeSelected = true;
        }

        private void hashComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashTypeSelected = true;
        }

        private void fileChecksumBtn_Click(object sender, EventArgs e)
        {
            if (fileChkSumSelected)
                if (hashTypeSelected)
                    checksumValueTextBox.Text = FileChecksum.computeChecksum(hashComboBox.Text, fileChkSumPathLabel.Text);
                else
                    MessageBox.Show("You must select a hash algorithm before computing the checksum.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("You must select a file to hash before computing the checksum.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void compareTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] byteArr = Conversions.ConvertToByteArray(compareTextBox.Text); //Conversions.HexToBytes(compareTextBox.Text);
                string byteArrStr = BitConverter.ToString(byteArr);

                if (String.Compare(checksumValueTextBox.Text, byteArrStr) == 0)
                {
                    matchLabel.Text = "Match";
                    matchLabel.ForeColor = Color.Green;
                }
                else
                {
                    matchLabel.Text = "Not a Match";
                    matchLabel.ForeColor = Color.Red;
                }
            }
            catch (ArgumentNullException) { } // Ignore
            catch (Exception ex)
            {
                MessageBox.Show("Error in comparison of the hash value. See message:\n" +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void autoKeyButton_Click(object sender, EventArgs e)
        {
            string key = FileEncryption.AutoGenerateKey();
            keyTextBox.Text = key;
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(passwordTextBox.Text, 
                new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
                0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 

            byte[] passBytes = pdb.GetBytes(32);
            string key = Conversions.ToHex(passBytes);
            keyTextBox.Text = key;
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileEncryptSelected)
                    if (encryptTypeSelected)
                    {
                        //FileEncryption.EncryptFile(inputFilePathLabel.Text,
                        //   outputFileTextBox.Text, keyTextBox.Text);
                        FileEncryption.Encrypt(inputFilePathLabel.Text,
                           outputFileTextBox.Text, keyTextBox.Text);
                        MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("You must select an encryption method before encrypting.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                    MessageBox.Show("You must select a file to encrypt before encrypting.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error encrypting the file." +
                    "See message:\n" + ex.Message,
                    "Error With Encryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void decryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fileEncryptSelected)
                    if (encryptTypeSelected)
                    {
                        //FileEncryption.DecryptFile(inputFilePathLabel.Text,
                        //   outputFileTextBox.Text, keyTextBox.Text);
                        FileEncryption.Decrypt(inputFilePathLabel.Text,
                           outputFileTextBox.Text, keyTextBox.Text);
                        MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("You must select an decryption method before decrypting.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                    MessageBox.Show("You must select a file to decrypt before decrypting.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error decrypting the file." +
                    " Did you use the correct key? See message:\n" + ex.Message,
                    "Error With Decryption", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
