using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int saat=0, dakika=0, saniye=0;
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.BackColor = Color.Black;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye==60)
            {
                timer2.Start();
                saniye = 0;
            }
            label3.Text = saniye.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            dakika++;
            if (dakika==60)
            {
                timer3.Start();
                dakika = 0;
             
            }
            label2.Text = dakika.ToString(); 
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
         
            saat++; progressBar1.Value += 1;
            if (saat==25)
            {
                saat = 0;
                dakika = 0;
                saniye = 0;

                progressBar1.Value = 0;
            }
            label1.Text = saat.ToString(); 
            timer3.Stop();                     
           
        } 
    }
}
