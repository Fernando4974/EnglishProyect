using EnglishProyect.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishProyect.view
{
    public partial class Form6 : FormA
    {
        Texts text = new Texts();
        public Form6()
        {
            InitializeComponent();
            //this.Load+=Form6_Load;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            etiquetaComun.Text += "4"+text.textosStagesContextos[2];
            
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA form7 = new Form7();
            form7.Show();
            this.Close();

        }
    }
}
