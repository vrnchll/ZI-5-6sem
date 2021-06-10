using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Graphs : Form
    {
        public Graphs()
        {
            InitializeComponent();

            for (int i = 0; i < Form1.alphabet.Length; i++)
            {
                asdTextBox.Text += $"{Form1.alphabet[i]}:{Form1.textP[i]} ";
                textChart.Series["Series1"].Points.AddXY(Form1.alphabet[i].ToString() ,Form1.textP[i]);;
            }
        }

        private void textChart_Click(object sender, EventArgs e)
        {

        }
    }
}
