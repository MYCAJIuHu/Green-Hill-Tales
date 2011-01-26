using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PcSpeakerMusicCreator
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int BeepFreq, int BeepDuration);

        public bool Check(Int32 a, Int32 b){
            if (a != b)
            {
                MessageBox.Show("Количетсво параметров столбца \"Тон\" не сответствует количеству параметров столбца \"Продолжительность\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check(textBox1.Lines.Count(),textBox2.Lines.Count()))
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    Beep(Convert.ToInt32(textBox1.Lines[i]), Convert.ToInt32(textBox2.Lines[i]));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check(textBox1.Lines.Count(), textBox2.Lines.Count()))
            {
                for (int i = 0; i < textBox1.Lines.Count(); i++)
                {
                    richTextBox1.AppendText("Beep("+textBox1.Lines[i]+","+textBox2.Lines[i]+");\n");
                }
            }
        }
    }
}
