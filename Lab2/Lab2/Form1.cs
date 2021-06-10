using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private string path = "";
        private StringBuilder text = new StringBuilder("");
        private string encryptedText = "";
        public static string alphabet = "абвгдеёжзіклмнопрстуўфхцчш'ыьэюя";
        private string keyWord = "бобрык";
        private string keyString = "";
        private int k = 5;
        public static List<double> textP = new List<double>();
        public static List<double> encryptedTextP = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            path = openFileDialog1.FileName;
            PathTextBox.Text = path;

            textP.Clear();

            using (StreamReader sr = new StreamReader(path))
            {
                text = new StringBuilder(sr.ReadToEnd().ToLower());
            }
            textBox.Text = text.ToString();

            foreach (var x in alphabet)
            {
                textP.Add((double)text.ToString().Count(s => s.Equals(x)) / (double)text.Length);
            }
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text.ToString()))
            {
                if (firstTask.Checked)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (alphabet.Contains(text[i]))
                        {
                            int index = alphabet.IndexOf(text[i]);
                            text[i] = alphabet[(index + k) % alphabet.Length];
                        }
                    }
                    textBox.Text = text.ToString();
                }

                if (secondTask.Checked)
                {
                    while (keyString.Length < text.Length)
                    {
                        keyString += keyWord;
                    }
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (alphabet.Contains(text[i]))
                        {
                            int index = alphabet.IndexOf(text[i]);
                            int keyIndex = alphabet.IndexOf(keyString[i]);
                            text[i] = alphabet[(index + keyIndex) % alphabet.Length];
                        }
                    }
                    keyString = "";
                    textBox.Text = text.ToString();
                }

                List<char> textChar = new List<char>(text.ToString());

                foreach (var x in alphabet)
                {
                    encryptedTextP.Add((double)(textChar.Select(s => s == x).Count()) / (double)(text.Length));
                }
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(text.ToString()))
            {
                if (firstTask.Checked)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (alphabet.Contains(text[i]))
                        {
                            int index = alphabet.IndexOf(text[i]);
                            int newIndex;
                            if ((index - k) % alphabet.Length < 0)
                                newIndex = alphabet.Length + ((index - k) % alphabet.Length);
                            else
                                newIndex = (index - k) % alphabet.Length;
                            text[i] = alphabet[newIndex];
                        }
                    }
                    textBox.Text = text.ToString();
                }

                if (secondTask.Checked)
                {
                    while (keyString.Length < text.Length)
                    {
                        keyString += keyWord;
                    }
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (alphabet.Contains(text[i]))
                        {
                            int index = alphabet.IndexOf(text[i]);
                            int keyIndex = alphabet.IndexOf(keyString[i]);
                            text[i] = alphabet[(index + alphabet.Length - keyIndex) % alphabet.Length];
                        }
                    }
                    keyString = "";
                    textBox.Text = text.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphs graphs = new Graphs();
            graphs.Show();
        }
    }
}
