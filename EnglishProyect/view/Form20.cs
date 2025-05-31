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
    public partial class Form20 : FormA
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }

        private void botonComun_Click(object sender, EventArgs e)
        {
            FormA fomrNew = new Form21();
            fomrNew.Show();
            this.Close();
        }
    }
}
