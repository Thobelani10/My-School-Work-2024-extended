using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        BusinesslayerClass businesslayer = new BusinesslayerClass();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string idNumber = textBox2.Text;
            int age = businesslayer.DetermineAge(idNumber);
            MessageBox.Show($"{name} {age}");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string idNumber = textBox2.Text;
            businesslayer.SavingToFile(name, idNumber);
            MessageBox.Show("Information is saved to the file!");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string[] data = businesslayer.ReadFromFile();
            string allTheInformation = string.Join(Environment.NewLine, data);
            MessageBox.Show(allTheInformation, "The information from the file has been read!");
        }
    }
}
