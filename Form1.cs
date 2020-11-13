using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmobaProjekt
{ 

    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           //Ez a gomb átváltja magát a Form2-re, ami a jatekForm megnevezést kapta.
            using (var form2 = new jatekForm())
            {
                form2.ShowDialog();
                
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }


    }
}
