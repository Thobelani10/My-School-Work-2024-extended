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

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        BusinessLayerClass business = new BusinessLayerClass();
        public int number;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string surname = textBox2.Text;
            string email = business.generateEmail(name, surname);
            label5.Text = email;
            string phoneNumber = business.formatNumber(number);
            textBox3.Text = phoneNumber;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string information = $"\t{textBox1.Text} \t {textBox2.Text} \t {label5.Text} \t {textBox3.Text}";
            business.SaveToFile(information);

            MessageBox.Show("Written to file....");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> records = business.ReadfromFiles();

            foreach(string record in records)
            {
                listBox1.Items.Add(record);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = string.Empty;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
