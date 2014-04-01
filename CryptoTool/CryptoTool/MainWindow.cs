using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptoTool
{
    public partial class MainWindow : Form
    {
        private bool fileSelected = false;
        private bool hashTypeSelected = false;

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
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePathLabel.Text = openFileDialog.FileName;
                fileSelected = true;
            }
        }

        private void hashComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hashTypeSelected = true;
        }

        private void fileChecksumBtn_Click(object sender, EventArgs e)
        {
            if (fileSelected)
                if (hashTypeSelected)
                    checksumValueTextBox.Text = FileChecksum.computeChecksum(hashComboBox.Text, filePathLabel.Text);
                else
                    MessageBox.Show("You must select a hash algorithm before computing the checksum.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("You must select a file to hash before computing the checksum.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
