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
    public partial class Form9 : FormA
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "7" + text.textosStagesContextos[5];
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form10();
            fomrNew.Show();
            this.Close();
        }
    }
}
