﻿namespace LAB_9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Encrypt = new System.Windows.Forms.Button();
            this.EncryptedMessage = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Decrypt = new System.Windows.Forms.Button();
            this.DecryptedMessage = new System.Windows.Forms.TextBox();
            this.ConvertedMessage = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeconvertedMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(9, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 23);
            this.textBox1.TabIndex = 0;
            // 
            // Encrypt
            // 
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Encrypt.Location = new System.Drawing.Point(469, 48);
            this.Encrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(122, 27);
            this.Encrypt.TabIndex = 1;
            this.Encrypt.Text = "Зашифровать";
            this.Encrypt.UseVisualStyleBackColor = true;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // EncryptedMessage
            // 
            this.EncryptedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EncryptedMessage.Location = new System.Drawing.Point(9, 143);
            this.EncryptedMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EncryptedMessage.Multiline = true;
            this.EncryptedMessage.Name = "EncryptedMessage";
            this.EncryptedMessage.ReadOnly = true;
            this.EncryptedMessage.Size = new System.Drawing.Size(583, 79);
            this.EncryptedMessage.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(405, 50);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(60, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // Decrypt
            // 
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Decrypt.Location = new System.Drawing.Point(469, 227);
            this.Decrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(120, 27);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.Text = "Расшифровать";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // DecryptedMessage
            // 
            this.DecryptedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DecryptedMessage.Location = new System.Drawing.Point(9, 258);
            this.DecryptedMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DecryptedMessage.Multiline = true;
            this.DecryptedMessage.Name = "DecryptedMessage";
            this.DecryptedMessage.ReadOnly = true;
            this.DecryptedMessage.Size = new System.Drawing.Size(583, 77);
            this.DecryptedMessage.TabIndex = 5;
            // 
            // ConvertedMessage
            // 
            this.ConvertedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ConvertedMessage.Location = new System.Drawing.Point(9, 80);
            this.ConvertedMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConvertedMessage.Multiline = true;
            this.ConvertedMessage.Name = "ConvertedMessage";
            this.ConvertedMessage.ReadOnly = true;
            this.ConvertedMessage.Size = new System.Drawing.Size(583, 22);
            this.ConvertedMessage.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(264, 50);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            35840,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 23);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown2.Location = new System.Drawing.Point(336, 50);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            35840,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(64, 23);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сообщение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "n1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "n2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Вид";
            // 
            // DeconvertedMessage
            // 
            this.DeconvertedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeconvertedMessage.Location = new System.Drawing.Point(9, 339);
            this.DeconvertedMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeconvertedMessage.Multiline = true;
            this.DeconvertedMessage.Name = "DeconvertedMessage";
            this.DeconvertedMessage.ReadOnly = true;
            this.DeconvertedMessage.Size = new System.Drawing.Size(583, 22);
            this.DeconvertedMessage.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Имя файла";
            // 
            // Path
            // 
            this.Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Path.Location = new System.Drawing.Point(63, 10);
            this.Path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(172, 23);
            this.Path.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(238, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Выбрать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(600, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DeconvertedMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ConvertedMessage);
            this.Controls.Add(this.DecryptedMessage);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.EncryptedMessage);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.TextBox EncryptedMessage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox DecryptedMessage;
        private System.Windows.Forms.TextBox ConvertedMessage;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DeconvertedMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button button1;
    }
}

