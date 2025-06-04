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
    public partial class Form13 : FormA
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            model.Texts text = new model.Texts();
            etiquetaComun.Text += "11" + text.textosStagesContextos[0];
        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form14();
            fomrNew.Show();
            this.Close();
        }
    }
}
