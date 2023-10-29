using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucuc_rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ip;
        private void button1_Click(object sender, EventArgs e)
        {
            
            int a=Convert.ToInt32(maskedTextBox1.Text);
           if(ip==a)
            {
                label8.Text = textBox1.Text;
                label7.Text = textBox2.Text;
                label6.Text = dateTimePicker1.Text;
                label5.Text = comboBox1.Text;
                listBox1.Items.Clear();
            }
           else
            {
                MessageBox.Show("Girilen Biletnumarası Tanımlı Değil");

            }
           
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
           
            Random rnd = new Random();
            ip = rnd.Next(1,35);

            listBox1.Items.Add("Bilet Numarası :" + ip.ToString() + "   Ad Soyad :" + textBox1.Text + "    Eposta :" + textBox2.Text + "    Kart Numarası :" + textBox3.Text + "    SonKulanım Tarihi:" + textBox4.Text  +  "  CVV :"+textBox5.Text + "Uçuş Yeri : " + comboBox1.Text  + "   Bilet Alım Tarihi :"+ dateTimePicker1.Text);
            
        }

        
    }
}
