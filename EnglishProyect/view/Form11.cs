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
    public partial class Form11 : FormA
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form12();
            fomrNew.Show();
            this.Close();
        }
    }
}
