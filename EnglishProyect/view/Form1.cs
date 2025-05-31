using EnglishProyect.view;
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

   

namespace EnglishProyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblTittle.BackColor = Color.Transparent;
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            view.Form2 form2 = new Form2();
            form2.Show();
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
