namespace CryptoTool
{
    partial class MainWindow
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
            this.fileChecksumBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.filePathLabelLabel = new System.Windows.Forms.Label();
            this.checksumValueTextBox = new System.Windows.Forms.TextBox();
            this.fileChkSumSelectBtn = new System.Windows.Forms.Button();
            this.fileChkSumPathLabel = new System.Windows.Forms.Label();
            this.hashComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compareTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.matchLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainWindowTabControl = new System.Windows.Forms.TabControl();
            this.encryptionTabPage = new System.Windows.Forms.TabPage();
            this.decryptButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.outputFileTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordButton = new System.Windows.Forms.Button();
            this.autoKeyButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.encryptButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.encryptComboBox = new System.Windows.Forms.ComboBox();
            this.fileEncryptSelectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputFilePathLabel = new System.Windows.Forms.Label();
            this.hashCheckerTabPage = new System.Windows.Forms.TabPage();
            this.mainWindowTabControl.SuspendLayout();
            this.encryptionTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.hashCheckerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileChecksumBtn
            // 
            this.fileChecksumBtn.Location = new System.Drawing.Point(177, 141);
            this.fileChecksumBtn.Name = "fileChecksumBtn";
            this.fileChecksumBtn.Size = new System.Drawing.Size(128, 23);
            this.fileChecksumBtn.TabIndex = 0;
            this.fileChecksumBtn.Text = "Compute Checksum";
            this.fileChecksumBtn.UseVisualStyleBackColor = true;
            this.fileChecksumBtn.Click += new System.EventHandler(this.fileChecksumBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hashed Value (32-bit, 2 digit hexidecimal values):";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "yourFileName.durp";
            // 
            // filePathLabelLabel
            // 
            this.filePathLabelLabel.AutoSize = true;
            this.filePathLabelLabel.Location = new System.Drawing.Point(6, 43);
            this.filePathLabelLabel.Name = "filePathLabelLabel";
            this.filePathLabelLabel.Size = new System.Drawing.Size(53, 13);
            this.filePathLabelLabel.TabIndex = 2;
            this.filePathLabelLabel.Text = "File path: ";
            // 
            // checksumValueTextBox
            // 
            this.checksumValueTextBox.Location = new System.Drawing.Point(6, 201);
            this.checksumValueTextBox.Multiline = true;
            this.checksumValueTextBox.Name = "checksumValueTextBox";
            this.checksumValueTextBox.ReadOnly = true;
            this.checksumValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.checksumValueTextBox.Size = new System.Drawing.Size(465, 77);
            this.checksumValueTextBox.TabIndex = 3;
            this.checksumValueTextBox.TextChanged += new System.EventHandler(this.compareTextBox_TextChanged);
            // 
            // fileChkSumSelectBtn
            // 
            this.fileChkSumSelectBtn.Location = new System.Drawing.Point(6, 6);
            this.fileChkSumSelectBtn.Name = "fileChkSumSelectBtn";
            this.fileChkSumSelectBtn.Size = new System.Drawing.Size(217, 23);
            this.fileChkSumSelectBtn.TabIndex = 4;
            this.fileChkSumSelectBtn.Text = "Select file on which to perform checksum";
            this.fileChkSumSelectBtn.UseVisualStyleBackColor = true;
            this.fileChkSumSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // fileChkSumPathLabel
            // 
            this.fileChkSumPathLabel.AutoSize = true;
            this.fileChkSumPathLabel.Location = new System.Drawing.Point(66, 43);
            this.fileChkSumPathLabel.Name = "fileChkSumPathLabel";
            this.fileChkSumPathLabel.Size = new System.Drawing.Size(0, 13);
            this.fileChkSumPathLabel.TabIndex = 5;
            // 
            // hashComboBox
            // 
            this.hashComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashComboBox.FormattingEnabled = true;
            this.hashComboBox.Location = new System.Drawing.Point(9, 98);
            this.hashComboBox.Name = "hashComboBox";
            this.hashComboBox.Size = new System.Drawing.Size(121, 21);
            this.hashComboBox.TabIndex = 6;
            this.hashComboBox.SelectedIndexChanged += new System.EventHandler(this.hashComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select hashing algorithm: ";
            // 
            // compareTextBox
            // 
            this.compareTextBox.Location = new System.Drawing.Point(6, 325);
            this.compareTextBox.Multiline = true;
            this.compareTextBox.Name = "compareTextBox";
            this.compareTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.compareTextBox.Size = new System.Drawing.Size(462, 78);
            this.compareTextBox.TabIndex = 8;
            this.compareTextBox.TextChanged += new System.EventHandler(this.compareTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Compare Against (Case Insensitive):";
            // 
            // matchLabel
            // 
            this.matchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.matchLabel.AutoSize = true;
            this.matchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchLabel.Location = new System.Drawing.Point(391, 309);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(77, 13);
            this.matchLabel.TabIndex = 10;
            this.matchLabel.Text = "Not a Match";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ex. 0F-8G-AB-06";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ex. 0f8gab06 or 0f-8g-ab-06 or 0F-8G-aB-06 etc.";
            // 
            // mainWindowTabControl
            // 
            this.mainWindowTabControl.Controls.Add(this.encryptionTabPage);
            this.mainWindowTabControl.Controls.Add(this.hashCheckerTabPage);
            this.mainWindowTabControl.Location = new System.Drawing.Point(10, 12);
            this.mainWindowTabControl.Name = "mainWindowTabControl";
            this.mainWindowTabControl.SelectedIndex = 0;
            this.mainWindowTabControl.Size = new System.Drawing.Size(491, 439);
            this.mainWindowTabControl.TabIndex = 13;
            // 
            // encryptionTabPage
            // 
            this.encryptionTabPage.Controls.Add(this.decryptButton);
            this.encryptionTabPage.Controls.Add(this.label11);
            this.encryptionTabPage.Controls.Add(this.outputFileTextBox);
            this.encryptionTabPage.Controls.Add(this.label10);
            this.encryptionTabPage.Controls.Add(this.keyTextBox);
            this.encryptionTabPage.Controls.Add(this.groupBox1);
            this.encryptionTabPage.Controls.Add(this.encryptButton);
            this.encryptionTabPage.Controls.Add(this.label7);
            this.encryptionTabPage.Controls.Add(this.encryptComboBox);
            this.encryptionTabPage.Controls.Add(this.fileEncryptSelectButton);
            this.encryptionTabPage.Controls.Add(this.label6);
            this.encryptionTabPage.Controls.Add(this.inputFilePathLabel);
            this.encryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.encryptionTabPage.Name = "encryptionTabPage";
            this.encryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionTabPage.Size = new System.Drawing.Size(483, 413);
            this.encryptionTabPage.TabIndex = 0;
            this.encryptionTabPage.Text = "File Encryption / Decryption";
            this.encryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(260, 333);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(72, 23);
            this.decryptButton.TabIndex = 17;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(387, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Output File Name (Ex. outfile.exe, outfile.enc, or 5fh56d9772d1f33dr8978g, etc.):" +
                "";
            // 
            // outputFileTextBox
            // 
            this.outputFileTextBox.Location = new System.Drawing.Point(19, 297);
            this.outputFileTextBox.Name = "outputFileTextBox";
            this.outputFileTextBox.Size = new System.Drawing.Size(446, 20);
            this.outputFileTextBox.TabIndex = 16;
            this.outputFileTextBox.Text = "outfile.enc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 233);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Secret Key (Protect this key):";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(19, 249);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(446, 20);
            this.keyTextBox.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordButton);
            this.groupBox1.Controls.Add(this.autoKeyButton);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(9, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key Generation Methods";
            // 
            // passwordButton
            // 
            this.passwordButton.Location = new System.Drawing.Point(10, 63);
            this.passwordButton.Name = "passwordButton";
            this.passwordButton.Size = new System.Drawing.Size(160, 23);
            this.passwordButton.TabIndex = 4;
            this.passwordButton.Text = "Generate Key From Password";
            this.passwordButton.UseVisualStyleBackColor = true;
            this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
            // 
            // autoKeyButton
            // 
            this.autoKeyButton.Location = new System.Drawing.Point(300, 37);
            this.autoKeyButton.Name = "autoKeyButton";
            this.autoKeyButton.Size = new System.Drawing.Size(133, 23);
            this.autoKeyButton.TabIndex = 3;
            this.autoKeyButton.Text = "Auto Generate Key";
            this.autoKeyButton.UseVisualStyleBackColor = true;
            this.autoKeyButton.Click += new System.EventHandler(this.autoKeyButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Method 2 (Auto-key generation):";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(10, 37);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(254, 20);
            this.passwordTextBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Method 1 (Password):";
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(150, 333);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(72, 23);
            this.encryptButton.TabIndex = 9;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Select encryption method: ";
            // 
            // encryptComboBox
            // 
            this.encryptComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encryptComboBox.FormattingEnabled = true;
            this.encryptComboBox.Location = new System.Drawing.Point(9, 84);
            this.encryptComboBox.Name = "encryptComboBox";
            this.encryptComboBox.Size = new System.Drawing.Size(121, 21);
            this.encryptComboBox.TabIndex = 10;
            this.encryptComboBox.SelectedIndexChanged += new System.EventHandler(this.encryptComboBox_SelectedIndexChanged);
            // 
            // fileEncryptSelectButton
            // 
            this.fileEncryptSelectButton.Location = new System.Drawing.Point(6, 6);
            this.fileEncryptSelectButton.Name = "fileEncryptSelectButton";
            this.fileEncryptSelectButton.Size = new System.Drawing.Size(173, 23);
            this.fileEncryptSelectButton.TabIndex = 7;
            this.fileEncryptSelectButton.Text = "Select file to encrypt/decrypt";
            this.fileEncryptSelectButton.UseVisualStyleBackColor = true;
            this.fileEncryptSelectButton.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "File path: ";
            // 
            // inputFilePathLabel
            // 
            this.inputFilePathLabel.AutoSize = true;
            this.inputFilePathLabel.Location = new System.Drawing.Point(66, 43);
            this.inputFilePathLabel.Name = "inputFilePathLabel";
            this.inputFilePathLabel.Size = new System.Drawing.Size(0, 13);
            this.inputFilePathLabel.TabIndex = 8;
            // 
            // hashCheckerTabPage
            // 
            this.hashCheckerTabPage.Controls.Add(this.fileChkSumSelectBtn);
            this.hashCheckerTabPage.Controls.Add(this.label5);
            this.hashCheckerTabPage.Controls.Add(this.fileChecksumBtn);
            this.hashCheckerTabPage.Controls.Add(this.label4);
            this.hashCheckerTabPage.Controls.Add(this.label1);
            this.hashCheckerTabPage.Controls.Add(this.matchLabel);
            this.hashCheckerTabPage.Controls.Add(this.filePathLabelLabel);
            this.hashCheckerTabPage.Controls.Add(this.label3);
            this.hashCheckerTabPage.Controls.Add(this.checksumValueTextBox);
            this.hashCheckerTabPage.Controls.Add(this.compareTextBox);
            this.hashCheckerTabPage.Controls.Add(this.fileChkSumPathLabel);
            this.hashCheckerTabPage.Controls.Add(this.label2);
            this.hashCheckerTabPage.Controls.Add(this.hashComboBox);
            this.hashCheckerTabPage.Location = new System.Drawing.Point(4, 22);
            this.hashCheckerTabPage.Name = "hashCheckerTabPage";
            this.hashCheckerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hashCheckerTabPage.Size = new System.Drawing.Size(483, 413);
            this.hashCheckerTabPage.TabIndex = 1;
            this.hashCheckerTabPage.Text = "File Hash Checker";
            this.hashCheckerTabPage.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 463);
            this.Controls.Add(this.mainWindowTabControl);
            this.Name = "MainWindow";
            this.Text = "CryptoTool";
            this.mainWindowTabControl.ResumeLayout(false);
            this.encryptionTabPage.ResumeLayout(false);
            this.encryptionTabPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.hashCheckerTabPage.ResumeLayout(false);
            this.hashCheckerTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileChecksumBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label filePathLabelLabel;
        private System.Windows.Forms.TextBox checksumValueTextBox;
        private System.Windows.Forms.Button fileChkSumSelectBtn;
        private System.Windows.Forms.Label fileChkSumPathLabel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox hashComboBox;
        private System.Windows.Forms.TextBox compareTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl mainWindowTabControl;
        private System.Windows.Forms.TabPage encryptionTabPage;
        private System.Windows.Forms.TabPage hashCheckerTabPage;
        private System.Windows.Forms.Button fileEncryptSelectButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inputFilePathLabel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox encryptComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox outputFileTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button passwordButton;
        private System.Windows.Forms.Button autoKeyButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button decryptButton;
    }
}

