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
    public partial class Form10 : FormA
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "8" + text.textosStagesContextos[4];
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form11();
            fomrNew.Show();
            this.Close();
        }
    }
}
