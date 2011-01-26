using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;


namespace CGT_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.SelectedItem == null)
            {
                input.Items.Add(textBox1.Text);
                textBox1.Text = "";
                input.SelectedItem = null;
            }
            else
            {
                input.Items[input.SelectedIndex] = textBox1.Text;
                textBox1.Text = "";
                button1.Text = "Добавить";
                input.SelectedItem = null;
            }
        }

        private void input_Click(object sender, EventArgs e)
        {
            if (input.SelectedItem != null)
            {
                textBox1.Text = input.SelectedItem.ToString();
                button1.Text = "Изменить";
            }
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (input.SelectedItem != null)
            {
                switch (e.KeyData)
                {
                    case Keys.Delete:
                        {
                            int i = input.SelectedIndex;
                            input.Items.RemoveAt(input.SelectedIndex);
                            input.SelectedIndex = i - 1;
                            break;
                        }
                    case Keys.Enter:
                        {
                            textBox1.Focus();
                            break;
                        }
                }
            }
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            string text = "";

            if (saveFileDialog1.FileName == "")
            {
                for (int i = 0; i < input.Items.Count; i++)
                {
                    text += input.Items[i].ToString()+"\n";
                    MessageBox.Show(text);
                }
            }
            else
            {
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.PerformClick();
            }
            if (e.KeyData == Keys.Down)
            {
                input.Focus();
                input.SelectedIndex = 0;
            }
        }
    }
}
