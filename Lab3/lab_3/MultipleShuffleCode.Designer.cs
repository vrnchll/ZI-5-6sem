﻿namespace lab_5
{
    partial class MultipleShuffleCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleShuffleCode));
            this.fileName = new System.Windows.Forms.Label();
            this.chartButton = new System.Windows.Forms.Button();
            this.TextInfo = new System.Windows.Forms.Label();
            this.gotoButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.decodeButton = new System.Windows.Forms.RadioButton();
            this.encodeButton = new System.Windows.Forms.RadioButton();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keyWord2 = new System.Windows.Forms.TextBox();
            this.keyWord1 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(164, 10);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 13);
            this.fileName.TabIndex = 16;
            // 
            // chartButton
            // 
            this.chartButton.AutoSize = true;
            this.chartButton.Enabled = false;
            this.chartButton.Image = ((System.Drawing.Image)(resources.GetObject("chartButton.Image")));
            this.chartButton.Location = new System.Drawing.Point(166, 210);
            this.chartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(56, 32);
            this.chartButton.TabIndex = 15;
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.chartButton_Click);
            // 
            // TextInfo
            // 
            this.TextInfo.AutoSize = true;
            this.TextInfo.Location = new System.Drawing.Point(164, 33);
            this.TextInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextInfo.Name = "TextInfo";
            this.TextInfo.Size = new System.Drawing.Size(0, 13);
            this.TextInfo.TabIndex = 14;
            // 
            // gotoButton
            // 
            this.gotoButton.Location = new System.Drawing.Point(226, 210);
            this.gotoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(186, 32);
            this.gotoButton.TabIndex = 13;
            this.gotoButton.Text = "Go to route shuffle code";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Enabled = false;
            this.executeButton.Location = new System.Drawing.Point(9, 210);
            this.executeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(150, 32);
            this.executeButton.TabIndex = 12;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Original text";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.decodeButton);
            this.groupBox2.Controls.Add(this.encodeButton);
            this.groupBox2.Location = new System.Drawing.Point(9, 115);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(150, 81);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // decodeButton
            // 
            this.decodeButton.AutoSize = true;
            this.decodeButton.Location = new System.Drawing.Point(6, 46);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(61, 17);
            this.decodeButton.TabIndex = 1;
            this.decodeButton.Text = "decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // encodeButton
            // 
            this.encodeButton.AutoSize = true;
            this.encodeButton.Checked = true;
            this.encodeButton.Location = new System.Drawing.Point(6, 24);
            this.encodeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(61, 17);
            this.encodeButton.TabIndex = 0;
            this.encodeButton.TabStop = true;
            this.encodeButton.Text = "encode";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(76, 4);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(82, 24);
            this.openFileButton.TabIndex = 9;
            this.openFileButton.Text = "Open file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "Text files|*.txt";
            this.openFileDialog1.Title = "Choose file";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text files|*.txt";
            this.saveFileDialog1.Title = "Save file";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keyWord2);
            this.groupBox1.Controls.Add(this.keyWord1);
            this.groupBox1.Location = new System.Drawing.Point(9, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Key words";
            // 
            // keyWord2
            // 
            this.keyWord2.Location = new System.Drawing.Point(4, 47);
            this.keyWord2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyWord2.Name = "keyWord2";
            this.keyWord2.Size = new System.Drawing.Size(142, 20);
            this.keyWord2.TabIndex = 1;
            // 
            // keyWord1
            // 
            this.keyWord1.Location = new System.Drawing.Point(4, 24);
            this.keyWord1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.keyWord1.Name = "keyWord1";
            this.keyWord1.Size = new System.Drawing.Size(142, 20);
            this.keyWord1.TabIndex = 0;
            this.keyWord1.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // MultipleShuffleCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(422, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.TextInfo);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.openFileButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MultipleShuffleCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultipleShuffleCode";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Label TextInfo;
        private System.Windows.Forms.Button gotoButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton decodeButton;
        private System.Windows.Forms.RadioButton encodeButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox keyWord2;
        private System.Windows.Forms.TextBox keyWord1;
    }
}