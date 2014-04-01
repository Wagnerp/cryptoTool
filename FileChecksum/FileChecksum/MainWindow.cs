using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace FileChecksum
{
    public partial class MainWindow : Form
    {
        private bool fileSelected = false;

        public MainWindow()
        {
            InitializeComponent();
            LoadHashAlgorithms();
        }

        private void LoadHashAlgorithms()
        {
            string[] algs = Properties.Settings.Default.HashAlgorithms.Split('\n');

            foreach (string alg in algs)
                hashComboBox.Items.Add(alg.Trim('\r'));
        }

        private void fileSelectBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select a file to perform a checksum on";
            openFileDialog.InitialDirectory = 
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            DialogResult result  = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePathLabel.Text = openFileDialog.FileName;
                fileSelected = true;
            }
        }
        
        private void fileChecksumBtn_Click(object sender, EventArgs e)
        {
            string hash = "";
            if(fileSelected)
                using (FileStream fs = new FileStream(filePathLabel.Text, FileMode.Open))
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    switch (hashComboBox.Text)
                    {
                        case "MD5":
                            hash = cryptoHash(new MD5CryptoServiceProvider(),bs);
                            break;
                        case "SHA1":
                            hash = cryptoHash(new SHA1CryptoServiceProvider(),bs);
                            break;
                        case "SHA256":
                            hash = cryptoHash(new SHA256CryptoServiceProvider(), bs);
                            break;
                        case "SHA384":
                            hash = cryptoHash(new SHA384CryptoServiceProvider(), bs);
                            break;
                        case "SHA512":
                            hash = cryptoHash(new SHA512CryptoServiceProvider(), bs);
                            break;
                    }

                    checksumValueTextBox.Text = hash;                   
                }
        }

        private string cryptoHash(MD5CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return(BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private string cryptoHash(SHA1CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private string cryptoHash(SHA256CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private string cryptoHash(SHA384CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }

        private string cryptoHash(SHA512CryptoServiceProvider cryptoProvider, BufferedStream bs)
        {
            using ((IDisposable)cryptoProvider)
            {
                return (BitConverter.ToString(cryptoProvider.ComputeHash(bs)));
            }
        }
    }
}
