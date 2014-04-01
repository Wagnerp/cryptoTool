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
            this.fileSelectBtn = new System.Windows.Forms.Button();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.hashComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.compareTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.matchLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.encryptionTabPage = new System.Windows.Forms.TabPage();
            this.hashCheckerTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.hashCheckerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileChecksumBtn
            // 
            this.fileChecksumBtn.Location = new System.Drawing.Point(171, 141);
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
            // 
            // fileSelectBtn
            // 
            this.fileSelectBtn.Location = new System.Drawing.Point(6, 6);
            this.fileSelectBtn.Name = "fileSelectBtn";
            this.fileSelectBtn.Size = new System.Drawing.Size(217, 23);
            this.fileSelectBtn.TabIndex = 4;
            this.fileSelectBtn.Text = "Select file on which to perform checksum";
            this.fileSelectBtn.UseVisualStyleBackColor = true;
            this.fileSelectBtn.Click += new System.EventHandler(this.fileSelectBtn_Click);
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(66, 43);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(0, 13);
            this.filePathLabel.TabIndex = 5;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.encryptionTabPage);
            this.tabControl1.Controls.Add(this.hashCheckerTabPage);
            this.tabControl1.Location = new System.Drawing.Point(10, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 439);
            this.tabControl1.TabIndex = 13;
            // 
            // encryptionTabPage
            // 
            this.encryptionTabPage.Location = new System.Drawing.Point(4, 22);
            this.encryptionTabPage.Name = "encryptionTabPage";
            this.encryptionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.encryptionTabPage.Size = new System.Drawing.Size(483, 413);
            this.encryptionTabPage.TabIndex = 0;
            this.encryptionTabPage.Text = "File Encryption";
            this.encryptionTabPage.UseVisualStyleBackColor = true;
            // 
            // hashCheckerTabPage
            // 
            this.hashCheckerTabPage.Controls.Add(this.fileSelectBtn);
            this.hashCheckerTabPage.Controls.Add(this.label5);
            this.hashCheckerTabPage.Controls.Add(this.fileChecksumBtn);
            this.hashCheckerTabPage.Controls.Add(this.label4);
            this.hashCheckerTabPage.Controls.Add(this.label1);
            this.hashCheckerTabPage.Controls.Add(this.matchLabel);
            this.hashCheckerTabPage.Controls.Add(this.filePathLabelLabel);
            this.hashCheckerTabPage.Controls.Add(this.label3);
            this.hashCheckerTabPage.Controls.Add(this.checksumValueTextBox);
            this.hashCheckerTabPage.Controls.Add(this.compareTextBox);
            this.hashCheckerTabPage.Controls.Add(this.filePathLabel);
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
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.Text = "File Hash Checker";
            this.tabControl1.ResumeLayout(false);
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
        private System.Windows.Forms.Button fileSelectBtn;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox hashComboBox;
        private System.Windows.Forms.TextBox compareTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage encryptionTabPage;
        private System.Windows.Forms.TabPage hashCheckerTabPage;
    }
}

