namespace Lab1
{
    partial class Lab1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MBox = new System.Windows.Forms.TextBox();
            this.NBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FindPrimeNumbers = new System.Windows.Forms.Button();
            this.TwoNumsCheckBox = new System.Windows.Forms.RadioButton();
            this.ThreeNumsCheckBox = new System.Windows.Forms.RadioButton();
            this.PrimeNubersBox = new System.Windows.Forms.TextBox();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.ThirdNum = new System.Windows.Forms.TextBox();
            this.NodButton = new System.Windows.Forms.Button();
            this.NodTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Поиск простых чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.НОД";
            // 
            // MBox
            // 
            this.MBox.Location = new System.Drawing.Point(41, 40);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(100, 20);
            this.MBox.TabIndex = 2;
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(41, 66);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(100, 20);
            this.NBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "m:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "n:";
            // 
            // FindPrimeNumbers
            // 
            this.FindPrimeNumbers.Location = new System.Drawing.Point(41, 92);
            this.FindPrimeNumbers.Name = "FindPrimeNumbers";
            this.FindPrimeNumbers.Size = new System.Drawing.Size(100, 23);
            this.FindPrimeNumbers.TabIndex = 6;
            this.FindPrimeNumbers.Text = "Найти";
            this.FindPrimeNumbers.UseVisualStyleBackColor = true;
            this.FindPrimeNumbers.Click += new System.EventHandler(this.FindPrimeNumbers_Click);
            // 
            // TwoNumsCheckBox
            // 
            this.TwoNumsCheckBox.AutoSize = true;
            this.TwoNumsCheckBox.Checked = true;
            this.TwoNumsCheckBox.Location = new System.Drawing.Point(12, 207);
            this.TwoNumsCheckBox.Name = "TwoNumsCheckBox";
            this.TwoNumsCheckBox.Size = new System.Drawing.Size(31, 17);
            this.TwoNumsCheckBox.TabIndex = 7;
            this.TwoNumsCheckBox.TabStop = true;
            this.TwoNumsCheckBox.Text = "2";
            this.TwoNumsCheckBox.UseVisualStyleBackColor = true;
            this.TwoNumsCheckBox.CheckedChanged += new System.EventHandler(this.TwoNumsCheckBox_CheckedChanged);
            // 
            // ThreeNumsCheckBox
            // 
            this.ThreeNumsCheckBox.AutoSize = true;
            this.ThreeNumsCheckBox.Location = new System.Drawing.Point(54, 207);
            this.ThreeNumsCheckBox.Name = "ThreeNumsCheckBox";
            this.ThreeNumsCheckBox.Size = new System.Drawing.Size(31, 17);
            this.ThreeNumsCheckBox.TabIndex = 8;
            this.ThreeNumsCheckBox.Text = "3";
            this.ThreeNumsCheckBox.UseVisualStyleBackColor = true;
            this.ThreeNumsCheckBox.CheckedChanged += new System.EventHandler(this.ThreeNumsCheckBox_CheckedChanged);
            // 
            // PrimeNubersBox
            // 
            this.PrimeNubersBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PrimeNubersBox.Location = new System.Drawing.Point(147, 40);
            this.PrimeNubersBox.Multiline = true;
            this.PrimeNubersBox.Name = "PrimeNubersBox";
            this.PrimeNubersBox.ReadOnly = true;
            this.PrimeNubersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PrimeNubersBox.Size = new System.Drawing.Size(141, 103);
            this.PrimeNubersBox.TabIndex = 9;
            // 
            // FirstNum
            // 
            this.FirstNum.Location = new System.Drawing.Point(12, 230);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(39, 20);
            this.FirstNum.TabIndex = 10;
            // 
            // SecondNum
            // 
            this.SecondNum.Location = new System.Drawing.Point(57, 230);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(39, 20);
            this.SecondNum.TabIndex = 11;
            // 
            // ThirdNum
            // 
            this.ThirdNum.Enabled = false;
            this.ThirdNum.Location = new System.Drawing.Point(102, 230);
            this.ThirdNum.Name = "ThirdNum";
            this.ThirdNum.Size = new System.Drawing.Size(39, 20);
            this.ThirdNum.TabIndex = 12;
            // 
            // NodButton
            // 
            this.NodButton.Location = new System.Drawing.Point(12, 256);
            this.NodButton.Name = "NodButton";
            this.NodButton.Size = new System.Drawing.Size(129, 23);
            this.NodButton.TabIndex = 13;
            this.NodButton.Text = "Посчитать";
            this.NodButton.UseVisualStyleBackColor = true;
            this.NodButton.Click += new System.EventHandler(this.NodButton_Click);
            // 
            // NodTextBox
            // 
            this.NodTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NodTextBox.Location = new System.Drawing.Point(147, 245);
            this.NodTextBox.Name = "NodTextBox";
            this.NodTextBox.ReadOnly = true;
            this.NodTextBox.Size = new System.Drawing.Size(75, 20);
            this.NodTextBox.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Количество взаимно простых чисел:";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.Location = new System.Drawing.Point(250, 146);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(16, 17);
            this.Count.TabIndex = 17;
            this.Count.Text = "0";
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(304, 300);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NodTextBox);
            this.Controls.Add(this.NodButton);
            this.Controls.Add(this.ThirdNum);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.PrimeNubersBox);
            this.Controls.Add(this.ThreeNumsCheckBox);
            this.Controls.Add(this.TwoNumsCheckBox);
            this.Controls.Add(this.FindPrimeNumbers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Lab1";
            this.ShowIcon = false;
            this.Text = "LR1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MBox;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindPrimeNumbers;
        private System.Windows.Forms.RadioButton TwoNumsCheckBox;
        private System.Windows.Forms.RadioButton ThreeNumsCheckBox;
        private System.Windows.Forms.TextBox PrimeNubersBox;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.TextBox SecondNum;
        private System.Windows.Forms.TextBox ThirdNum;
        private System.Windows.Forms.Button NodButton;
        private System.Windows.Forms.TextBox NodTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Count;
    }
}

