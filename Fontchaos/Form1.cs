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
using Microsoft.Office;



namespace Fontchaos
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog FileChecked;
        bool HasFile = false;

        private void GetFileClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                sr.Close();
                CheckFile(openFileDialog1);
            }
        }

        private void CheckFile(OpenFileDialog TXTFile) {
            if (Path.GetExtension(TXTFile.FileName) == ".txt")
            {
                ChooseFileTextBox.Text = TXTFile.FileName;
                FileChecked = TXTFile;
                HasFile = true;
                richTextBox1.Text = File.ReadAllText(FileChecked.FileName);
            }
        }

        private void RandomizeButtonClick(object sender, EventArgs e) { 
            Random rnd = new Random();
            for (int i = 0; i < richTextBox1.TextLength; i++)
            {
                richTextBox1.Select(i, 1);

                richTextBox1.SelectionFont = new Font(FontFamily.Families[rnd.Next(FontFamily.Families.Count())], 12f + rnd.Next(6));
                richTextBox1.SelectionColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                richTextBox1.SelectionBackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
