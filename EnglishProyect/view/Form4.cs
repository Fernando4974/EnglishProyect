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
    public partial class Form4 : FormA
    {
        model.Texts text = new model.Texts();   
        public Form4()
        {

            InitializeComponent();
            this.Load += Form4_Load;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            etiquetaComun.Text += text.textosStagesContextos[1];
        }

       

        private void botonComun_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }
    }
}
