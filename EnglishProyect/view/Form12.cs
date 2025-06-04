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
    public partial class Form12 : FormA
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "10" + text.textosStagesContextos[1];
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form13();
            fomrNew.Show();
            this.Close();
        }
    }
}
