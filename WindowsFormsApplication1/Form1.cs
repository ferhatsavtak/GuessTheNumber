using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
        }
        int sayi=0 ;
        double sayac=0 ;
        private void button1_Click(object sender, EventArgs e)
        {

          

            sayac++;
            
            int gir= Convert.ToInt32(textBox1.Text);
            string ad = textBox4.Text;
            string soyad = textBox5.Text;
            listBox1.Items.Add(gir);

            if (gir > sayi)
            {
                
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
                
            }

            else if (gir < sayi)
            {
              
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                
            }
            else  
                MessageBox.Show("Tebrikler " + sayac + " Tahminde Bildiniz");
           
                      
            if (gir == sayi & sayac < 5)
                
              listBox2.Items.Add(ad + " " + soyad + " " + sayac);
           
                
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public int gir { get; set; }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 0;
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);
            Random Rastgele = new Random();
            if (x < y) 
            sayi = Rastgele.Next(x, y);
            else 
            sayi=Rastgele.Next(y, x);
        }


        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public int aralik2 { get; set; }

        public int x { get; set; }

        public int y { get; set; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
