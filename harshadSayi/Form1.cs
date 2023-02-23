using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harshadSayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kT = 0;
        
        int sayi1;
        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            int sayibirtutucu = sayi1;
            kT = 0;
            
            
            textBox1.Text = "";
            
            while (sayi1>0)
            {
                                
                int sayininKalani = sayi1 % 10;
                sayi1 =sayi1/ 10;
                kT = kT + sayininKalani;
    
               
            }
            if (sayibirtutucu % kT == 0)
            {
                listBox1.Items.Add(sayibirtutucu);
            }
        }
    }
}
