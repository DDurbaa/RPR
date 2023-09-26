using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zvireprorytire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vstup = textBox1.Text.Trim();
            int pocet = 0;
            foreach(char c in vstup)
            {
                if(c ==' ')
                {
                    pocet++;
                }    
            }
            MessageBox.Show("pocet slov " + pocet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
